/**
 * Assembly Developer API .NET Client
 * SDK Version 2.2.474
 * API Version 1.1.0
 *
 * Support
 * Email: help@assembly.education
 * URL:   http://developers.assembly.education
 *
 * Terms of Service: http://assembly.education/terms/
 * License:          MIT, https://spdx.org/licenses/MIT.html
 */


using System.Dynamic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AssemblyClient
{
  public static class HttpResponseMessageExtensions
  {
    public static Task EnsurePlatformSuccess(this HttpResponseMessage response)
    {
      if (response.StatusCode == (HttpStatusCode)429)
      {
        dynamic error = response.Deserialize();
        var message = error.Result.error;
        var data = error.Result.data;

        throw new RequestThrottledException(message, (int)data.count, (int)data.period, (int)data.limit);
      }

      return response.EnsureSuccessfulStatusCode();
    }

    public static async Task EnsureSuccessfulStatusCode(this HttpResponseMessage response)
    {
      if (response.IsSuccessStatusCode || response.StatusCode == (HttpStatusCode)304)
      {
        return;
      }

      var content = string.Empty;

      if (response.Content != null)
      {
        content = await response.Content.ReadAsStringAsync();
        response.Content.Dispose();
      }

      throw new HttpResponseDetailedException(response.StatusCode, content);
    }

    public static async Task<dynamic> Deserialize(this HttpResponseMessage response)
    {
      return await response.Deserialize<ExpandoObject>();
    }

    public static async Task<T> Deserialize<T>(this HttpResponseMessage response)
    {
      var result = await response.Content.ReadAsStringAsync();
      var data = JsonConvert.DeserializeObject<T>(result);
      return data;
    }

    public static async Task<bool> IsValidToken(this HttpResponseMessage response)
    {
      if (response.StatusCode == HttpStatusCode.Unauthorized)
      {
        var error = await response.Deserialize();

        var tokenValid = error.error != "invalid_token";

        return tokenValid;
      }

      return true;
    }
  }
}
