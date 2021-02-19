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
  public class Attendance
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("student_id")]
    public int? StudentId { get; set; }

    [JsonProperty("registration_group_id")]
    public int? RegistrationGroupId { get; set; }

    [JsonProperty("group_id")]
    public int? GroupId { get; set; }

    [JsonProperty("session_date")]
    public DateTime? SessionDate { get; set; }

    [JsonProperty("session_name")]
    public string SessionName { get; set; }

    [JsonProperty("attendance_mark")]
    public string AttendanceMark { get; set; }

    [JsonProperty("minutes_late")]
    public int? MinutesLate { get; set; }

    [JsonProperty("comments")]
    public string Comments { get; set; }


    public Attendance()
    {
    }
  }
}
