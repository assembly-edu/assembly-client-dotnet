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
  public class LessonGroup
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("code")]
    public string Code { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("mis_subject")]
    public LessonGroupMisSubject MisSubject { get; set; }

    [JsonProperty("subject")]
    public MisSubjectSubject Subject { get; set; }


    public LessonGroup()
    {
      MisSubject = new LessonGroupMisSubject();
      Subject = new MisSubjectSubject();
    }
  }
}
