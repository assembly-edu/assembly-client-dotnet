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
  public class ExclusionsResource : Resource
  {
    public ExclusionsResource(ApiClient client)
      : base(client)
    {
    }

    /// <summary>
    /// List Exclusions
    /// </summary>
    /// <remarks>
    /// Returns a list of exclusions. *By default, exclusions are returned that occurred during the current academic year.*
    /// </remarks>
    /// <param name="studentId">Filter to the specified student (optional)</param>
    /// <param name="startDate">The start date of the period to filter by (optional)</param>
    /// <param name="endDate">The end date of the period to filter by (optional)</param>
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;Exclusion&gt;</returns>
    public async Task<List<Exclusion>> List(
      int? studentId = null, 
      DateTime? startDate = null, 
      DateTime? endDate = null, 
      int? perPage = null, 
      int? page = null
    )
    {
      dynamic args = new ExpandoObject();
      args.studentId = studentId;
      args.startDate = startDate;
      args.endDate = endDate;
      args.perPage = perPage;
      args.page = page;
      var results = await Client.GetList<Exclusion>($"/exclusions", args);
      return results;
    }

  }

  public partial class ApiClient
  {
    public ExclusionsResource Exclusions => new ExclusionsResource(this);
  }
}
