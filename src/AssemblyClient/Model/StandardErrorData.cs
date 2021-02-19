/**
 * Assembly Developer API .NET Client
 * SDK Version 2.2.472
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
  public class StandardErrorData
  {
    [JsonProperty("count")]
    public int? Count { get; set; }

    [JsonProperty("period")]
    public int? Period { get; set; }

    [JsonProperty("limit")]
    public int? Limit { get; set; }


    public StandardErrorData()
    {
    }
  }
}
