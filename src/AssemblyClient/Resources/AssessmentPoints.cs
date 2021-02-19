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
  public class AssessmentPointsResource : Resource
  {
    public AssessmentPointsResource(ApiClient client)
      : base(client)
    {
    }

    /// <summary>
    /// View an Assessment Point
    /// </summary>
    /// <remarks>
    /// Returns a single assessment point for the given rank
    /// </remarks>
    /// <param name="assessmentPointRank">The rank of the assessment point as an Integer</param>
    /// <returns>AssessmentPoint</returns>
    public async Task<AssessmentPoint> Find(
      int? assessmentPointRank
    )
    {
      dynamic args = new ExpandoObject();
      var result = await Client.GetObject<AssessmentPoint>($"/assessment_points/{assessmentPointRank}", args);
      return result;
    }

    /// <summary>
    /// List Assessment Points
    /// </summary>
    /// <remarks>
    /// Returns a list of assessment points. An &#x60;assessment_point&#x60; object represents a point in the school key stage, year, term or half-term that results can be attached to. When sending results back to the Platform, the &#x60;assessment_point_rank&#x60; should be used - this will remain constant across all environments
    /// </remarks>
    /// <param name="yearCode">Filter by school year (optional)</param>
    /// <param name="type">Filter by type (optional)</param>
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;AssessmentPoint&gt;</returns>
    public async Task<List<AssessmentPoint>> List(
      int? yearCode = null, 
      string type = null, 
      int? perPage = null, 
      int? page = null
    )
    {
      dynamic args = new ExpandoObject();
      args.yearCode = yearCode;
      args.type = type;
      args.perPage = perPage;
      args.page = page;
      var results = await Client.GetList<AssessmentPoint>($"/assessment_points", args);
      return results;
    }

    /// <summary>
    /// View Results for an Assessment Point
    /// </summary>
    /// <remarks>
    /// Returns a list of results for the given &#x60;assessment_point_rank&#x60; and students
    /// </remarks>
    /// <param name="assessmentPointRank">The rank of the assessment point as an Integer</param>
    /// <param name="students">ID(s) of the student(s) as an Integer. Multiple IDs can be separated with a space (so a + URL encoded)</param>
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;Result&gt;</returns>
    public async Task<List<Result>> Results(
      int? assessmentPointRank, 
      List<int?> students, 
      int? perPage = null, 
      int? page = null
    )
    {
      dynamic args = new ExpandoObject();
      args.students = students;
      args.perPage = perPage;
      args.page = page;
      var results = await Client.GetList<Result>($"/assessment_points/{assessmentPointRank}/results", args);
      return results;
    }

  }

  public partial class ApiClient
  {
    public AssessmentPointsResource AssessmentPoints => new AssessmentPointsResource(this);
  }
}
