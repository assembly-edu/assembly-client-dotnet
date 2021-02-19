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


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {
  public class Exclusion
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("student_id")]
    public int? StudentId { get; set; }

    [JsonProperty("exclusion_type")]
    public string ExclusionType { get; set; }

    [JsonProperty("exclusion_reason")]
    public string ExclusionReason { get; set; }

    [JsonProperty("exclusion_reason_2")]
    public string ExclusionReason2 { get; set; }

    [JsonProperty("exclusion_reason_3")]
    public string ExclusionReason3 { get; set; }

    [JsonProperty("start_date")]
    public DateTime? StartDate { get; set; }

    [JsonProperty("start_session")]
    public string StartSession { get; set; }

    [JsonProperty("end_date")]
    public DateTime? EndDate { get; set; }

    [JsonProperty("end_session")]
    public string EndSession { get; set; }

    [JsonProperty("exclusion_length")]
    public int? ExclusionLength { get; set; }


    public Exclusion()
    {
    }
  }
}
