/**
 * Assembly Developer API .NET Client
 * SDK Version 2.2.473
 * API Version 1.1.0
 *
 * Support
 * Email: help@assembly.education
 * URL:   http://developers.assembly.education
 *
 * Terms of Service: http://assembly.education/terms/
 * License:          MIT, https://spdx.org/licenses/MIT.html
 */


using Newtonsoft.Json;

namespace AssemblyClient
{
  internal class ApiGrant
  {
    [JsonProperty("grant_type")]
    public string GrantType
    {
      get { return "refresh_token"; }
    }

    [JsonProperty("refresh_token")]
    public string RefreshToken { get; set; }

    public ApiGrant(string refreshToken)
    {
      this.RefreshToken = refreshToken;
    }
  }
}
