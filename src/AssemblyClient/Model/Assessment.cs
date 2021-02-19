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
  public class Assessment
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("family_id")]
    public int? FamilyId { get; set; }

    [JsonProperty("family_name")]
    public string FamilyName { get; set; }

    [JsonProperty("mis_assessments")]
    public List<string> MisAssessments { get; set; }


    public Assessment()
    {
      MisAssessments = new List<string>();
    }
  }
}
