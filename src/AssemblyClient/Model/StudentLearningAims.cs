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
  public class StudentLearningAims
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("learning_aim_source_id")]
    public int? LearningAimSourceId { get; set; }

    [JsonProperty("start_date")]
    public DateTime? StartDate { get; set; }

    [JsonProperty("planned_end_date")]
    public DateTime? PlannedEndDate { get; set; }

    [JsonProperty("actual_end_date")]
    public DateTime? ActualEndDate { get; set; }

    [JsonProperty("completion_status")]
    public string CompletionStatus { get; set; }

    [JsonProperty("withdrawal_reason")]
    public string WithdrawalReason { get; set; }

    [JsonProperty("core_aim_indicator")]
    public bool? CoreAimIndicator { get; set; }


    public StudentLearningAims()
    {
    }
  }
}
