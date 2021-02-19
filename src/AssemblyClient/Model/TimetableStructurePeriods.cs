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


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {
  public class TimetableStructurePeriods
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("short_name")]
    public string ShortName { get; set; }

    [JsonProperty("long_name")]
    public string LongName { get; set; }

    [JsonProperty("start_time")]
    public string StartTime { get; set; }

    [JsonProperty("end_time")]
    public string EndTime { get; set; }

    [JsonProperty("display_order")]
    public int? DisplayOrder { get; set; }


    public TimetableStructurePeriods()
    {
    }
  }
}
