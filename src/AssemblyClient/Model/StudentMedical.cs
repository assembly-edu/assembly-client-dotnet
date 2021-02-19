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
  public class StudentMedical
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("nhs_number")]
    public string NhsNumber { get; set; }

    [JsonProperty("is_pregnant")]
    public bool? IsPregnant { get; set; }

    [JsonProperty("has_emergency_consent")]
    public bool? HasEmergencyConsent { get; set; }

    [JsonProperty("conditions")]
    public List<StudentMedicalCondition> Conditions { get; set; }

    [JsonProperty("dietary_needs")]
    public List<string> DietaryNeeds { get; set; }

    [JsonProperty("notes")]
    public List<StudentMedicalNote> Notes { get; set; }


    public StudentMedical()
    {
      Conditions = new List<StudentMedicalCondition>();
      DietaryNeeds = new List<string>();
      Notes = new List<StudentMedicalNote>();
    }
  }
}
