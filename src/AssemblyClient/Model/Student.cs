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
  public class Student
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("year_code")]
    public string YearCode { get; set; }

    [JsonProperty("upn")]
    public string Upn { get; set; }

    [JsonProperty("former_upn")]
    public string FormerUpn { get; set; }

    [JsonProperty("uln")]
    public string Uln { get; set; }

    [JsonProperty("mis_id")]
    public string MisId { get; set; }

    [JsonProperty("pan")]
    public string Pan { get; set; }

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

    [JsonProperty("dob")]
    public DateTime? Dob { get; set; }

    [JsonProperty("start_date")]
    public DateTime? StartDate { get; set; }

    [JsonProperty("end_date")]
    public DateTime? EndDate { get; set; }

    [JsonProperty("enrolment_status")]
    public string EnrolmentStatus { get; set; }

    [JsonProperty("demographics")]
    public StudentDemographics Demographics { get; set; }

    [JsonProperty("medical")]
    public StudentMedical Medical { get; set; }

    [JsonProperty("contacts")]
    public List<StudentContacts> Contacts { get; set; }

    [JsonProperty("emails")]
    public List<EmailInfo> Emails { get; set; }

    [JsonProperty("address")]
    public StudentAddress Address { get; set; }

    [JsonProperty("languages")]
    public StudentLanguages Languages { get; set; }

    [JsonProperty("learning_aims")]
    public StudentLearningAims LearningAims { get; set; }

    [JsonProperty("photo")]
    public StudentPhoto Photo { get; set; }


    public Student()
    {
      Demographics = new StudentDemographics();
      Medical = new StudentMedical();
      Contacts = new List<StudentContacts>();
      Emails = new List<EmailInfo>();
      Address = new StudentAddress();
      Languages = new StudentLanguages();
      LearningAims = new StudentLearningAims();
      Photo = new StudentPhoto();
    }
  }
}
