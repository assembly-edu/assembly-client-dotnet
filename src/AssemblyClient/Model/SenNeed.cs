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
  public class SenNeed
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("start_date")]
    public string StartDate { get; set; }

    [JsonProperty("sen_need_type_code")]
    public string SenNeedTypeCode { get; set; }

    [JsonProperty("sen_need_type_name")]
    public string SenNeedTypeName { get; set; }

    [JsonProperty("sen_broad_need_type_code")]
    public string SenBroadNeedTypeCode { get; set; }

    [JsonProperty("sen_broad_need_type_name")]
    public string SenBroadNeedTypeName { get; set; }

    [JsonProperty("priority")]
    public int? Priority { get; set; }


    public SenNeed()
    {
    }
  }
}
