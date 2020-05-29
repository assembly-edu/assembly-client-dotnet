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
  public class StaffMember
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("mis_id")]
    public string MisId { get; set; }

    [JsonProperty("staff_code")]
    public string StaffCode { get; set; }

    [JsonProperty("first_name")]
    public string FirstName { get; set; }

    [JsonProperty("legal_first_name")]
    public string LegalFirstName { get; set; }

    [JsonProperty("middle_name")]
    public string MiddleName { get; set; }

    [JsonProperty("last_name")]
    public string LastName { get; set; }

    [JsonProperty("legal_last_name")]
    public string LegalLastName { get; set; }

    [JsonProperty("former_last_name")]
    public string FormerLastName { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("salutation")]
    public string Salutation { get; set; }

    [JsonProperty("dob")]
    public DateTime? Dob { get; set; }

    [JsonProperty("address")]
    public StaffMemberAddress Address { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("emails")]
    public List<EmailInfo> Emails { get; set; }

    [JsonProperty("telephone_numbers")]
    public List<TelephoneNumberInfo> TelephoneNumbers { get; set; }

    [JsonProperty("is_teaching_staff")]
    public bool? IsTeachingStaff { get; set; }

    [JsonProperty("included_in_census")]
    public bool? IncludedInCensus { get; set; }

    [JsonProperty("start_date")]
    public DateTime? StartDate { get; set; }

    [JsonProperty("end_date")]
    public DateTime? EndDate { get; set; }

    [JsonProperty("demographics")]
    public StaffMemberDemographics Demographics { get; set; }

    [JsonProperty("qualification_info")]
    public StaffMemberQualificationInfo QualificationInfo { get; set; }


    public StaffMember()
    {
      Address = new StaffMemberAddress();
      Emails = new List<EmailInfo>();
      TelephoneNumbers = new List<TelephoneNumberInfo>();
      Demographics = new StaffMemberDemographics();
      QualificationInfo = new StaffMemberQualificationInfo();
    }
  }
}
