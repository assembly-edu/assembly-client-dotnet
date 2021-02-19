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
  public class TimetableLessons
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("group")]
    public TimetableGroup Group { get; set; }

    [JsonProperty("start_date")]
    public DateTime? StartDate { get; set; }

    [JsonProperty("end_date")]
    public DateTime? EndDate { get; set; }

    [JsonProperty("supervisors")]
    public List<TimetableSupervisors> Supervisors { get; set; }

    [JsonProperty("rooms")]
    public List<LessonRooms> Rooms { get; set; }


    public TimetableLessons()
    {
      Group = new TimetableGroup();
      Supervisors = new List<TimetableSupervisors>();
      Rooms = new List<LessonRooms>();
    }
  }
}
