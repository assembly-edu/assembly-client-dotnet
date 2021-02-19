/**
 * Assembly Developer API .NET Client
 * SDK Version 2.2.473
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
using System.Dynamic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AssemblyClient
{
  public class SchoolsResource : Resource
  {
    public SchoolsResource(ApiClient client)
      : base(client)
    {
    }

    /// <summary>
    /// Deauthorize School
    /// </summary>
    /// <remarks>
    /// Disable your application for the school associated with the provided &#x60;access_token&#x60;
    /// </remarks>
    /// <returns></returns>
    public async Task<HttpResponseMessage> Deauthorize(
    )
    {
      var result = await Client.SendData(new HttpMethod("POST"), $"/school/deauthorize");
      return result;
    }

    /// <summary>
    /// View School Details
    /// </summary>
    /// <remarks>
    /// Returns details for the school associated with the provided &#x60;access_token&#x60;
    /// </remarks>
    /// <returns>School</returns>
    public async Task<School> Show(
    )
    {
      dynamic args = new ExpandoObject();
      var result = await Client.GetObject<School>($"/school", args);
      return result;
    }

    /// <summary>
    /// View School Sync Status
    /// </summary>
    /// <remarks>
    /// Returns status for the school associated with the provided &#x60;access_token&#x60;
    /// </remarks>
    /// <returns>SchoolStatus</returns>
    public async Task<SchoolStatus> Status(
    )
    {
      dynamic args = new ExpandoObject();
      var result = await Client.GetObject<SchoolStatus>($"/school/status", args);
      return result;
    }

    /// <summary>
    /// Request a School Sync
    /// </summary>
    /// <remarks>
    /// Returns a sync request status for the school associated with the provided &#x60;access_token&#x60;
    /// </remarks>
    /// <returns></returns>
    public async Task<HttpResponseMessage> Sync(
    )
    {
      var result = await Client.SendData(new HttpMethod("POST"), $"/school/sync");
      return result;
    }

  }

  public partial class ApiClient
  {
    public SchoolsResource Schools => new SchoolsResource(this);
  }
}
