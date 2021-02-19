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
using System.Dynamic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AssemblyClient
{
  public class FacetsResource : Resource
  {
    public FacetsResource(ApiClient client)
      : base(client)
    {
    }

    /// <summary>
    /// View a Facet
    /// </summary>
    /// <remarks>
    /// Returns a single facet for the given ID
    /// </remarks>
    /// <param name="id">Internal identifier of the entity</param>
    /// <returns>Facet</returns>
    public async Task<Facet> Find(
      int? id
    )
    {
      dynamic args = new ExpandoObject();
      var result = await Client.GetObject<Facet>($"/facets/{id}", args);
      return result;
    }

    /// <summary>
    /// List Facets
    /// </summary>
    /// <remarks>
    /// Returns a list of facets. The facet is used to reflect a different type of grade and allows 2 grades of the same assessment to be compared
    /// </remarks>
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;Facet&gt;</returns>
    public async Task<List<Facet>> List(
      int? perPage = null, 
      int? page = null
    )
    {
      dynamic args = new ExpandoObject();
      args.perPage = perPage;
      args.page = page;
      var results = await Client.GetList<Facet>($"/facets", args);
      return results;
    }

  }

  public partial class ApiClient
  {
    public FacetsResource Facets => new FacetsResource(this);
  }
}
