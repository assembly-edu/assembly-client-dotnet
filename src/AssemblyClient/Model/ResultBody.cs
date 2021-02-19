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
  public class ResultBody
  {
    [JsonProperty("subject_id")]
    public int? SubjectId { get; set; }

    [JsonProperty("facet_id")]
    public int? FacetId { get; set; }

    [JsonProperty("assessment_point_rank")]
    public int? AssessmentPointRank { get; set; }

    [JsonProperty("assessment_id")]
    public int? AssessmentId { get; set; }

    [JsonProperty("results")]
    public List<ResultEntry> Results { get; set; }


    public ResultBody()
    {
      Results = new List<ResultEntry>();
    }
  }
}
