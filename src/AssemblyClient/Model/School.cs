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
  public class School
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("slug")]
    public string Slug { get; set; }

    [JsonProperty("urn")]
    public string Urn { get; set; }

    [JsonProperty("mis_provider")]
    public string MisProvider { get; set; }

    [JsonProperty("la_code")]
    public int? LaCode { get; set; }

    [JsonProperty("la_name")]
    public string LaName { get; set; }

    [JsonProperty("establishment_number")]
    public int? EstablishmentNumber { get; set; }

    [JsonProperty("establishment_type")]
    public string EstablishmentType { get; set; }

    [JsonProperty("phase")]
    public string Phase { get; set; }

    [JsonProperty("street")]
    public string Street { get; set; }

    [JsonProperty("town")]
    public string Town { get; set; }

    [JsonProperty("postcode")]
    public string Postcode { get; set; }

    [JsonProperty("head_teacher")]
    public string HeadTeacher { get; set; }


    public School()
    {
    }
  }
}
