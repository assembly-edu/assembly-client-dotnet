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
  public class StaffQualification
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("qualification_code")]
    public string QualificationCode { get; set; }

    [JsonProperty("degree_class")]
    public string DegreeClass { get; set; }

    [JsonProperty("first_subject_code")]
    public string FirstSubjectCode { get; set; }

    [JsonProperty("first_subject_name")]
    public string FirstSubjectName { get; set; }

    [JsonProperty("second_subject_code")]
    public string SecondSubjectCode { get; set; }

    [JsonProperty("second_subject_name")]
    public string SecondSubjectName { get; set; }


    public StaffQualification()
    {
    }
  }
}
