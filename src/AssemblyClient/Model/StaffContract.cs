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
  public class StaffContract
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("staff_member_id")]
    public int? StaffMemberId { get; set; }

    [JsonProperty("start_date")]
    public DateTime? StartDate { get; set; }

    [JsonProperty("end_date")]
    public DateTime? EndDate { get; set; }

    [JsonProperty("national_insurance_number")]
    public string NationalInsuranceNumber { get; set; }

    [JsonProperty("payroll_number")]
    public string PayrollNumber { get; set; }

    [JsonProperty("contract_type")]
    public string ContractType { get; set; }

    [JsonProperty("post")]
    public string Post { get; set; }

    [JsonProperty("origin")]
    public string Origin { get; set; }

    [JsonProperty("destination")]
    public string Destination { get; set; }

    [JsonProperty("daily_rate")]
    public bool? DailyRate { get; set; }

    [JsonProperty("pay_review_date")]
    public DateTime? PayReviewDate { get; set; }

    [JsonProperty("roles")]
    public List<StaffRole> Roles { get; set; }

    [JsonProperty("salaries")]
    public List<StaffSalary> Salaries { get; set; }

    [JsonProperty("allowances")]
    public List<StaffAllowance> Allowances { get; set; }


    public StaffContract()
    {
      Roles = new List<StaffRole>();
      Salaries = new List<StaffSalary>();
      Allowances = new List<StaffAllowance>();
    }
  }
}
