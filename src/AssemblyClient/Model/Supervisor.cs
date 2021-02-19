/**
 * Assembly Developer API .NET Client
 * SDK Version 2.2.475
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
  public class Supervisor
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("staff_member_id")]
    public int? StaffMemberId { get; set; }

    [JsonProperty("role")]
    public string Role { get; set; }


    public Supervisor()
    {
    }
  }
}
