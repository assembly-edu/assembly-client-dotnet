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
  public class StudentMedicalNote
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("summary")]
    public string Summary { get; set; }

    [JsonProperty("detail")]
    public string Detail { get; set; }

    [JsonProperty("created_by_id")]
    public int? CreatedById { get; set; }

    [JsonProperty("last_modified_by_id")]
    public int? LastModifiedById { get; set; }

    [JsonProperty("last_modified_date")]
    public DateTime? LastModifiedDate { get; set; }


    public StudentMedicalNote()
    {
    }
  }
}
