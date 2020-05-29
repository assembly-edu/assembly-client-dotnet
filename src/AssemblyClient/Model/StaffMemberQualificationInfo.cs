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
  public class StaffMemberQualificationInfo
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("teacher_number")]
    public string TeacherNumber { get; set; }

    [JsonProperty("qt_status")]
    public bool? QtStatus { get; set; }

    [JsonProperty("hlta_status")]
    public bool? HltaStatus { get; set; }

    [JsonProperty("qts_route")]
    public string QtsRoute { get; set; }

    [JsonProperty("qualifications")]
    public List<StaffQualification> Qualifications { get; set; }


    public StaffMemberQualificationInfo()
    {
      Qualifications = new List<StaffQualification>();
    }
  }
}
