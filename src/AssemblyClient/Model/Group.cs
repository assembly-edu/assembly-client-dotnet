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
  public class Group
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("code")]
    public string Code { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("mis_subject")]
    public GroupMisSubject MisSubject { get; set; }

    [JsonProperty("start_date")]
    public DateTime? StartDate { get; set; }

    [JsonProperty("end_date")]
    public DateTime? EndDate { get; set; }

    [JsonProperty("supervisors")]
    public List<Supervisor> Supervisors { get; set; }

    [JsonProperty("student_ids")]
    public List<int?> StudentIds { get; set; }


    public Group()
    {
      MisSubject = new GroupMisSubject();
      Supervisors = new List<Supervisor>();
      StudentIds = new List<int?>();
    }
  }
}
