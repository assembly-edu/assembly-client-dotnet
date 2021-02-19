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
  public class Contact
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("mis_id")]
    public string MisId { get; set; }

    [JsonProperty("first_name")]
    public string FirstName { get; set; }

    [JsonProperty("middle_name")]
    public string MiddleName { get; set; }

    [JsonProperty("last_name")]
    public string LastName { get; set; }

    [JsonProperty("gender")]
    public string Gender { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("salutation")]
    public string Salutation { get; set; }

    [JsonProperty("address")]
    public ContactAddress Address { get; set; }

    [JsonProperty("emails")]
    public List<EmailInfo> Emails { get; set; }

    [JsonProperty("telephone_numbers")]
    public List<TelephoneNumberInfo> TelephoneNumbers { get; set; }

    [JsonProperty("students")]
    public List<ContactStudents> Students { get; set; }


    public Contact()
    {
      Address = new ContactAddress();
      Emails = new List<EmailInfo>();
      TelephoneNumbers = new List<TelephoneNumberInfo>();
      Students = new List<ContactStudents>();
    }
  }
}
