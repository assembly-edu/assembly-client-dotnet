/**
 * Assembly Developer API .NET Client
 * SDK Version 2.2.472
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
  public class StudentContactRelationship
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("relationship_type")]
    public string RelationshipType { get; set; }

    [JsonProperty("priority")]
    public int? Priority { get; set; }

    [JsonProperty("parental_responsibility")]
    public bool? ParentalResponsibility { get; set; }


    public StudentContactRelationship()
    {
    }
  }
}
