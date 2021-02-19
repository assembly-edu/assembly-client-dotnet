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
  public class MisSubjectsResource : Resource
  {
    public MisSubjectsResource(ApiClient client)
      : base(client)
    {
    }

    /// <summary>
    /// List MIS Subjects
    /// </summary>
    /// <remarks>
    /// Returns a list of the schools&#39;s mis subjects
    /// </remarks>
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;MisSubject&gt;</returns>
    public async Task<List<MisSubject>> List(
      int? perPage = null, 
      int? page = null
    )
    {
      dynamic args = new ExpandoObject();
      args.perPage = perPage;
      args.page = page;
      var results = await Client.GetList<MisSubject>($"/mis_subjects", args);
      return results;
    }

  }

  public partial class ApiClient
  {
    public MisSubjectsResource MisSubjects => new MisSubjectsResource(this);
  }
}
