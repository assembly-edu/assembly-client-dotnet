/**
 * Assembly Developer API .NET Client
 * SDK Version 2.2.464
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
  public class AssessmentsResource : Resource
  {
    public AssessmentsResource(ApiClient client)
      : base(client)
    {
    }

    /// <summary>
    /// View an Assessment
    /// </summary>
    /// <remarks>
    /// Returns a single assessment for the given ID
    /// </remarks>
    /// <param name="id">Internal identifier of the entity</param>
    /// <returns>Assessment</returns>
    public async Task<Assessment> Find(
      int? id
    )
    {
      dynamic args = new ExpandoObject();
      var result = await Client.GetObject<Assessment>($"/assessments/{id}", args);
      return result;
    }

    /// <summary>
    /// View Grade Set for an Assessment
    /// </summary>
    /// <remarks>
    /// Returns a &#x60;grade_set&#x60; (an acceptable list of values) for the assessment identifierentified by the &#x60;assessment_id&#x60;. Grades should be written back to the Platform using the &#x60;grade_id&#x60;
    /// </remarks>
    /// <param name="id">Internal identifier of the entity</param>
    /// <returns>GradeSet</returns>
    public async Task<GradeSet> GradeSet(
      int? id
    )
    {
      dynamic args = new ExpandoObject();
      var result = await Client.GetObject<GradeSet>($"/assessments/{id}/grade_set", args);
      return result;
    }

    /// <summary>
    /// List Assessments
    /// </summary>
    /// <remarks>
    /// Returns a list of assessment objects. The assessment is the grouping that knits together a range of concepts. The name of the assessment also refers to the source of the result
    /// </remarks>
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;Assessment&gt;</returns>
    public async Task<List<Assessment>> List(
      int? perPage = null, 
      int? page = null
    )
    {
      dynamic args = new ExpandoObject();
      args.perPage = perPage;
      args.page = page;
      var results = await Client.GetList<Assessment>($"/assessments", args);
      return results;
    }

    /// <summary>
    /// View Results for an Assessment
    /// </summary>
    /// <remarks>
    /// Returns a list of results for the given &#x60;assessment_id&#x60; and students. For a full list of national assessment data (Key stage 1 and 2 SATs results) available on the Platform, please see this [support article](http://help.assembly.education/article/89-getting-prior-attainment-from-the-platform)
    /// </remarks>
    /// <param name="id">Internal identifier of the entity</param>
    /// <param name="students">ID(s) of the student(s) as an Integer. Multiple IDs can be separated with a space (so a + URL encoded)</param>
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;Result&gt;</returns>
    public async Task<List<Result>> Results(
      int? id, 
      List<int?> students, 
      int? perPage = null, 
      int? page = null
    )
    {
      dynamic args = new ExpandoObject();
      args.students = students;
      args.perPage = perPage;
      args.page = page;
      var results = await Client.GetList<Result>($"/assessments/{id}/results", args);
      return results;
    }

  }

  public partial class ApiClient
  {
    public AssessmentsResource Assessments => new AssessmentsResource(this);
  }
}
