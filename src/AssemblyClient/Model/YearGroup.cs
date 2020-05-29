/**
 * Assembly Developer API .NET Client
 * SDK Version 2.2.464
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
  public class YearGroup
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("code")]
    public string Code { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("start_date")]
    public DateTime? StartDate { get; set; }

    [JsonProperty("end_date")]
    public DateTime? EndDate { get; set; }

    [JsonProperty("supervisor_ids")]
    public List<int?> SupervisorIds { get; set; }

    [JsonProperty("student_ids")]
    public List<int?> StudentIds { get; set; }


    public YearGroup()
    {
      SupervisorIds = new List<int?>();
      StudentIds = new List<int?>();
    }
  }
}
