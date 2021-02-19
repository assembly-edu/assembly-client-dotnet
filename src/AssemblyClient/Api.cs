/**
 * Assembly Developer API .NET Client
 * SDK Version 2.2.471
 * API Version 1.1.0
 *
 * Support
 * Email: help@assembly.education
 * URL:   http://developers.assembly.education
 *
 * Terms of Service: http://assembly.education/terms/
 * License:          MIT, https://spdx.org/licenses/MIT.html
 */


using System;
using System.Dynamic;
using System.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AssemblyClient
{
  public class Api
  {
    private readonly HttpClient client;

    public ApiConfiguration Configuration { get; set; }

    public EventHandler<TokenRefreshedEventArgs> TokenRefreshed { get; set; }

    internal void OnTokenRefreshed(string newToken)
    {
      TokenRefreshed?.Invoke(this, new TokenRefreshedEventArgs { Token = newToken });
    }

    public Api()
    {
    }

    public Api(HttpClient client)
    {
      this.client = client;
      this.client.DefaultRequestHeaders.Add("Accept", "application/vnd.assembly+json; version=1.1");

      TokenRefreshed += (sender, args) => { };
    }

    public virtual async Task<HttpResponseMessage> SendData(HttpMethod method, string uri)
    {
      try {
        var response = await client.SendData(method, uri, Configuration.Token);
        var isTokenValid = await response.IsValidToken();

        if (Configuration.Debug)
        {
          Console.WriteLine($"Assembly API POST: {uri}");
        }

        if (!isTokenValid)
        {
          var newToken = await RefreshToken(Configuration.RefreshToken);
          Configuration.Token = newToken;

          OnTokenRefreshed(newToken);

          response = await client.SendData(method, uri, Configuration.Token);
        }

        return response;
      }
      catch(Exception e) {
        throw new ApiException(client.BaseAddress, uri, $"Failed to {method.Method} data to the platform", e);
      }
    }

    public virtual async Task<T> SendData<T>(HttpMethod method, string uri, object data)
    {
      try {
        var response = await client.SendData(method, uri, Configuration.Token, data);
        var isTokenValid = await response.IsValidToken();

        if (Configuration.Debug)
        {
          Console.WriteLine($"Assembly API POST: {uri}");
        }

        if (!isTokenValid)
        {
          var newToken = await RefreshToken(Configuration.RefreshToken);
          Configuration.Token = newToken;

          OnTokenRefreshed(newToken);

          response = await client.SendData(method, uri, Configuration.Token, data);
          await response.EnsurePlatformSuccess();
        }
        else
        {
          await response.EnsurePlatformSuccess();
        }

        var result = await response.Deserialize<T>();
        return result;
      }
      catch(Exception e) {
        throw new ApiException(client.BaseAddress, uri, $"Failed to {method.Method} data to the platform", e);
      }
    }

    public virtual async Task<HttpResponseMessage> Load(string resource)
    {
      var result = await Load(resource, new ExpandoObject());
      return result;
    }

    private async Task<string> RefreshToken(string refreshToken)
    {
      client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Configuration.BasicAuth);

      var refreshRequest = new ApiGrant(refreshToken);
      var response = await client.SendData(HttpMethod.Post, "/oauth/token", Configuration.Token, refreshRequest);

      if (Configuration.Debug)
      {
        Console.WriteLine($"Assembly API Token Refresh");
      }

      await response.EnsurePlatformSuccess();

      var refreshedToken = await response.Deserialize();
      return refreshedToken.access_token;
    }

    public virtual async Task<HttpResponseMessage> Load(string resource, ExpandoObject args)
    {
      var parsedArgs = (IDictionary<string, object>) args;

      if (parsedArgs.ContainsKey("ifModifiedSince") && parsedArgs["ifModifiedSince"] != null)
      {
        if (!client.DefaultRequestHeaders.Contains("If-Modified-Since"))
        {
          client.DefaultRequestHeaders.Add("If-Modified-Since", ((DateTime)parsedArgs["ifModifiedSince"]).ToString("r"));
        } else {
          client.DefaultRequestHeaders.IfModifiedSince = ((DateTime)parsedArgs["ifModifiedSince"]);
        }
        parsedArgs.Remove("ifModifiedSince");
      }

      var resourceWithQuery = CreateResourceWithQuery(resource, (ExpandoObject) parsedArgs);

      if (Configuration.Debug)
      {
        Console.WriteLine($"Assembly API GET: {resourceWithQuery}");
      }

      var response = await client.MakeRequest(resourceWithQuery, Configuration.Token);
      var isTokenValid = await response.IsValidToken();

      if (!isTokenValid)
      {
        var newToken = await RefreshToken(Configuration.RefreshToken);
        Configuration.Token = newToken;

        OnTokenRefreshed(newToken);

        response = await client.MakeRequest(resourceWithQuery, Configuration.Token);
        await response.EnsurePlatformSuccess();
      }
      else
      {
        await response.EnsurePlatformSuccess();
      }

      return response;
    }

    public virtual async Task<IList<T>> GetList<T>(string resource, ExpandoObject args)
    {
      var results = new List<T>();
      bool allPages = true;
      dynamic queryArgs = args;
      object page;

      try
      {
        if (((IDictionary<string, object>) queryArgs).TryGetValue("page", out page) && page != null)
        {
          allPages = false;
        }
        else
        {
          queryArgs.page = 1;
        }

        do
        {
          try
          {
            var response = await Load(resource, queryArgs);

            var data = await response.Content.ReadAsStringAsync();

            if (string.IsNullOrWhiteSpace(data)) {
              data = "[]";
            }

            var list = JsonConvert.DeserializeObject<List<T>>(data);

            results.AddRange(list);

            var nextPage = GetHeaderAsString(response.Headers, "Next-Page");

            if (string.IsNullOrEmpty(nextPage) || !allPages)
            {
              queryArgs.page = null;
            }
            else
            {
              queryArgs.page = int.Parse(nextPage);
            }
          }
          catch (RequestThrottledException ex)
          {
            var waitingPeriod = ex.Period * 1000;
            if (Configuration.Debug)
            {
              Console.WriteLine($"Assembly API rate limit hit at {DateTime.Now} due to reaching {ex.Count} requests in {ex.Period} seconds when limit is {ex.Limit} waiting {ex.Period} second before retrying");
            }
            await Task.Delay(waitingPeriod);
            if (Configuration.Debug)
            {
              Console.WriteLine($"Assembly API rate limit hit waited period of {ex.Period} seconds finished at {DateTime.Now} now retrying");
            }
          }
        } while (queryArgs.page != null);
      }
      catch(Exception e) {
        throw new ApiException(client.BaseAddress, CreateResourceWithQuery(resource, args), $"Error getting list of objects from {resource}", e);
      }

      return results;
    }

    public virtual async Task<T> GetObject<T>(string resource, ExpandoObject args)
    {
      try {
        var data = await Load(resource, args);
        var rawData = await data.Content.ReadAsStringAsync();
        var obj = JsonConvert.DeserializeObject<T>(rawData);
        return obj;
      }
      catch(Exception e) {
        throw new ApiException(client.BaseAddress, CreateResourceWithQuery(resource, args), $"Error getting object from {resource}", e);
      }
    }

    private string CreateResourceWithQuery(string resource, ExpandoObject args)
    {
      var query = args.ToParams();
      var resourceWithQuery = $"{resource}";

      if (!string.IsNullOrEmpty(query))
      {
        resourceWithQuery = $"{resourceWithQuery}?{query}";
      }

      return resourceWithQuery;
    }

    private string GetHeaderAsString(HttpHeaders headers, string name)
    {
      IEnumerable<string> values;
      if (headers.TryGetValues(name, out values))
      {
        return values.FirstOrDefault();
      }
      return null;
    }
  }
}
