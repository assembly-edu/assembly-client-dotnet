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
  public class TeachingGroup
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("start_date")]
    public DateTime? StartDate { get; set; }

    [JsonProperty("end_date")]
    public DateTime? EndDate { get; set; }

    [JsonProperty("academic_year_id")]
    public int? AcademicYearId { get; set; }

    [JsonProperty("supervisor_ids")]
    public List<int?> SupervisorIds { get; set; }

    [JsonProperty("student_ids")]
    public List<int?> StudentIds { get; set; }

    [JsonProperty("subject")]
    public Subject Subject { get; set; }

    [JsonProperty("mis_level")]
    public string MisLevel { get; set; }

    [JsonProperty("assessment")]
    public Assessment Assessment { get; set; }


    public TeachingGroup()
    {
      SupervisorIds = new List<int?>();
      StudentIds = new List<int?>();
      Subject = new Subject();
      Assessment = new Assessment();
    }
  }
}
