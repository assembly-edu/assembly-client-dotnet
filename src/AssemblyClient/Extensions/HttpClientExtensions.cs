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


using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AssemblyClient
{
  public static class HttpClientExtensions
  {
    private static void SetAuthorizationHeader(this HttpClient me, string token)
    {
      me.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
    }

    public static async Task<HttpResponseMessage> MakeRequest(this HttpClient me, string resourceWithQuery, string token)
    {
      me.SetAuthorizationHeader(token);
      var response = await me.GetAsync(resourceWithQuery);
      return response;
    }

    public static async Task<HttpResponseMessage> SendData(this HttpClient me, HttpMethod method, string uri, string token)
    {
      return await SendData(me, method, uri, token, null);
    }

    public static async Task<HttpResponseMessage> SendData(this HttpClient me, HttpMethod method, string uri, string token, object data)
    {
      if (uri != "/oauth/token")
      {
        me.SetAuthorizationHeader(token);
      }

      if (data == null)
      {
        var response = await me.SendAsync(new HttpRequestMessage(method, uri));
        return response;
      }
      else
      {
        var serialized = JsonConvert.SerializeObject(data);
        var content = new StringContent(serialized, Encoding.UTF8, "application/json");
        var response = await me.SendAsync(new HttpRequestMessage(method, uri)
        {
          Content = content
        });
        return response;
      }
    }
  }
}
