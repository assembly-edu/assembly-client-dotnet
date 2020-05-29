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
  public class StaffMemberDemographics
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("ethnicity_code")]
    public string EthnicityCode { get; set; }

    [JsonProperty("ethnicity_group")]
    public string EthnicityGroup { get; set; }

    [JsonProperty("gender")]
    public string Gender { get; set; }

    [JsonProperty("disability")]
    public string Disability { get; set; }

    [JsonProperty("disability_cdoe")]
    public string DisabilityCdoe { get; set; }


    public StaffMemberDemographics()
    {
    }
  }
}
