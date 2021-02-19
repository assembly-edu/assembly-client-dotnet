/**
 * Assembly Developer API .NET Client
 * SDK Version 2.2.471
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
  public class StudentDemographics
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("ethnicity_code")]
    public string EthnicityCode { get; set; }

    [JsonProperty("ethnicity_group")]
    public string EthnicityGroup { get; set; }

    [JsonProperty("gender")]
    public string Gender { get; set; }

    [JsonProperty("is_pp")]
    public bool? IsPp { get; set; }

    [JsonProperty("pp_history")]
    public List<PpEntitlement> PpHistory { get; set; }

    [JsonProperty("is_eal")]
    public bool? IsEal { get; set; }

    [JsonProperty("sen_category")]
    public string SenCategory { get; set; }

    [JsonProperty("sen_category_history")]
    public List<SenCategory> SenCategoryHistory { get; set; }

    [JsonProperty("country_of_birth")]
    public string CountryOfBirth { get; set; }

    [JsonProperty("nationalities")]
    public List<string> Nationalities { get; set; }

    [JsonProperty("fsm_review_date")]
    public string FsmReviewDate { get; set; }

    [JsonProperty("is_fsm")]
    public bool? IsFsm { get; set; }

    [JsonProperty("is_fsm6")]
    public bool? IsFsm6 { get; set; }

    [JsonProperty("fsm_history")]
    public List<FsmEntitlement> FsmHistory { get; set; }

    [JsonProperty("in_care")]
    public bool? InCare { get; set; }

    [JsonProperty("ever_in_care")]
    public bool? EverInCare { get; set; }

    [JsonProperty("service_child")]
    public bool? ServiceChild { get; set; }

    [JsonProperty("sen_needs")]
    public List<SenNeed> SenNeeds { get; set; }


    public StudentDemographics()
    {
      PpHistory = new List<PpEntitlement>();
      SenCategoryHistory = new List<SenCategory>();
      Nationalities = new List<string>();
      FsmHistory = new List<FsmEntitlement>();
      SenNeeds = new List<SenNeed>();
    }
  }
}
