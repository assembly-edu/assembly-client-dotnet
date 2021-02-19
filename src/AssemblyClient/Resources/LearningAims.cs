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
  public class LearningAimsResource : Resource
  {
    public LearningAimsResource(ApiClient client)
      : base(client)
    {
    }

    /// <summary>
    /// View a Post-16 Learning Aim
    /// </summary>
    /// <remarks>
    /// Returns a Post-16 Learning Aim retrieved by ID
    /// </remarks>
    /// <param name="id">Internal identifier of the entity</param>
    /// <returns>LearningAim</returns>
    public async Task<LearningAim> Find(
      int? id
    )
    {
      dynamic args = new ExpandoObject();
      var result = await Client.GetObject<LearningAim>($"/school/learning_aims/{id}", args);
      return result;
    }

    /// <summary>
    /// List Post-16 Learning Aims
    /// </summary>
    /// <remarks>
    /// Returns a list of Post-16 Learning Aims defined within the school
    /// </remarks>
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;LearningAim&gt;</returns>
    public async Task<List<LearningAim>> List(
      int? perPage = null, 
      int? page = null
    )
    {
      dynamic args = new ExpandoObject();
      args.perPage = perPage;
      args.page = page;
      var results = await Client.GetList<LearningAim>($"/school/learning_aims", args);
      return results;
    }

  }

  public partial class ApiClient
  {
    public LearningAimsResource LearningAims => new LearningAimsResource(this);
  }
}
