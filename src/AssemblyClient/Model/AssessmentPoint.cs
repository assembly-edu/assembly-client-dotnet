/**
 * Assembly Developer API .NET Client
 * SDK Version 2.2.470
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
  public class AssessmentPoint
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("rank")]
    public int? Rank { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("year_code")]
    public string YearCode { get; set; }


    public AssessmentPoint()
    {
    }
  }
}
