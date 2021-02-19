/**
 * Assembly Developer API .NET Client
 * SDK Version 2.2.472
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
  public class DietaryNeedsResource : Resource
  {
    public DietaryNeedsResource(ApiClient client)
      : base(client)
    {
    }

    /// <summary>
    /// View a Dietary Need
    /// </summary>
    /// <remarks>
    /// Returns a single dietary need for the given ID
    /// </remarks>
    /// <param name="id">Internal identifier of the entity</param>
    /// <returns>DietaryNeed</returns>
    public async Task<DietaryNeed> Find(
      int? id
    )
    {
      dynamic args = new ExpandoObject();
      var result = await Client.GetObject<DietaryNeed>($"/school/dietary_needs/{id}", args);
      return result;
    }

    /// <summary>
    /// List Dietary Needs
    /// </summary>
    /// <remarks>
    /// Returns a list of all the Dietary Needs defined by the school
    /// </remarks>
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;DietaryNeed&gt;</returns>
    public async Task<List<DietaryNeed>> List(
      int? perPage = null, 
      int? page = null
    )
    {
      dynamic args = new ExpandoObject();
      args.perPage = perPage;
      args.page = page;
      var results = await Client.GetList<DietaryNeed>($"/school/dietary_needs", args);
      return results;
    }

  }

  public partial class ApiClient
  {
    public DietaryNeedsResource DietaryNeeds => new DietaryNeedsResource(this);
  }
}
