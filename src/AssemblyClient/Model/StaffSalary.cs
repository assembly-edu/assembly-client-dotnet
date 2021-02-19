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
  public class StaffSalary
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("hours_per_week")]
    public float? HoursPerWeek { get; set; }

    [JsonProperty("fte")]
    public float? Fte { get; set; }

    [JsonProperty("weeks_per_year")]
    public float? WeeksPerYear { get; set; }

    [JsonProperty("pay_range")]
    public string PayRange { get; set; }

    [JsonProperty("start_date")]
    public DateTime? StartDate { get; set; }

    [JsonProperty("end_date")]
    public DateTime? EndDate { get; set; }

    [JsonProperty("pay_scale_framework")]
    public string PayScaleFramework { get; set; }

    [JsonProperty("regional_spine")]
    public string RegionalSpine { get; set; }

    [JsonProperty("base_pay")]
    public float? BasePay { get; set; }

    [JsonProperty("actual_pay")]
    public float? ActualPay { get; set; }

    [JsonProperty("safeguarded_salary")]
    public bool? SafeguardedSalary { get; set; }


    public StaffSalary()
    {
    }
  }
}
