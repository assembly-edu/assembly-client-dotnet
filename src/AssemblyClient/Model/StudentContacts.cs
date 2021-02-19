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
  public class StudentContacts
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("contact_id")]
    public int? ContactId { get; set; }

    [JsonProperty("relationship")]
    public StudentContactRelationship Relationship { get; set; }


    public StudentContacts()
    {
      Relationship = new StudentContactRelationship();
    }
  }
}
