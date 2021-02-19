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
  public class Me
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("decription")]
    public string Decription { get; set; }

    [JsonProperty("website_uri")]
    public string WebsiteUri { get; set; }

    [JsonProperty("support_uri")]
    public string SupportUri { get; set; }

    [JsonProperty("privacy_policy_uri")]
    public string PrivacyPolicyUri { get; set; }

    [JsonProperty("redirect_uri")]
    public string RedirectUri { get; set; }

    [JsonProperty("install_uri")]
    public string InstallUri { get; set; }

    [JsonProperty("listed")]
    public bool? Listed { get; set; }

    [JsonProperty("sandbox")]
    public bool? Sandbox { get; set; }

    [JsonProperty("force_urn_check")]
    public bool? ForceUrnCheck { get; set; }

    [JsonProperty("created_at")]
    public DateTime? CreatedAt { get; set; }

    [JsonProperty("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [JsonProperty("token")]
    public MeToken Token { get; set; }


    public Me()
    {
      Token = new MeToken();
    }
  }
}
