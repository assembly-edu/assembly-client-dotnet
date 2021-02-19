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
  public class TelephoneNumberInfo
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("telephone_number")]
    public string TelephoneNumber { get; set; }

    [JsonProperty("is_primary")]
    public bool? IsPrimary { get; set; }


    public TelephoneNumberInfo()
    {
    }
  }
}
