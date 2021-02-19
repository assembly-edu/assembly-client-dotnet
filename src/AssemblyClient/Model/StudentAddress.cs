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
  public class StudentAddress
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("address_line_1")]
    public string AddressLine1 { get; set; }

    [JsonProperty("address_line_2")]
    public string AddressLine2 { get; set; }

    [JsonProperty("town_city")]
    public string TownCity { get; set; }

    [JsonProperty("county")]
    public string County { get; set; }

    [JsonProperty("country")]
    public string Country { get; set; }

    [JsonProperty("postcode")]
    public string Postcode { get; set; }


    public StudentAddress()
    {
    }
  }
}
