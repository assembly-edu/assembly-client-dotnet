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
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {
  public class MeToken
  {
    [JsonProperty("access_level")]
    public string AccessLevel { get; set; }

    [JsonProperty("scopes")]
    public List<string> Scopes { get; set; }


    public MeToken()
    {
      Scopes = new List<string>();
    }
  }
}
