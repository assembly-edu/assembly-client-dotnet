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
  public class AttendanceSummary
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

    [JsonProperty("academic_year_id")]
    public int? AcademicYearId { get; set; }

    [JsonProperty("start_date")]
    public DateTime? StartDate { get; set; }

    [JsonProperty("end_date")]
    public DateTime? EndDate { get; set; }

    [JsonProperty("possible_sessions")]
    public float? PossibleSessions { get; set; }

    [JsonProperty("attended_sessions")]
    public float? AttendedSessions { get; set; }

    [JsonProperty("late_sessions")]
    public float? LateSessions { get; set; }

    [JsonProperty("authorised_absence_sessions")]
    public float? AuthorisedAbsenceSessions { get; set; }

    [JsonProperty("unauthorised_absence_sessions")]
    public float? UnauthorisedAbsenceSessions { get; set; }


    public AttendanceSummary()
    {
    }
  }
}
