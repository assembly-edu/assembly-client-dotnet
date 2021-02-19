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
using System.Dynamic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AssemblyClient
{
  public class ApplicationsResource : Resource
  {
    public ApplicationsResource(ApiClient client)
      : base(client)
    {
    }

    /// <summary>
    /// View your Application
    /// </summary>
    /// <remarks>
    /// Returns the record of your application in the Assembly platform, as well as information on what token was used to access the endpoint
    /// </remarks>
    /// <returns>Me</returns>
    public async Task<Me> Me(
    )
    {
      dynamic args = new ExpandoObject();
      var result = await Client.GetObject<Me>($"/me", args);
      return result;
    }

  }

  public partial class ApiClient
  {
    public ApplicationsResource Applications => new ApplicationsResource(this);
  }
}
