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
  public class SchoolStatus
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("last_changes_at")]
    public DateTime? LastChangesAt { get; set; }

    [JsonProperty("last_sync_at")]
    public DateTime? LastSyncAt { get; set; }

    [JsonProperty("last_sync_status")]
    public string LastSyncStatus { get; set; }


    public SchoolStatus()
    {
    }
  }
}
