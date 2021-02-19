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
  public class ResultsResource : Resource
  {
    public ResultsResource(ApiClient client)
      : base(client)
    {
    }

    /// <summary>
    /// Update Multiple Results
    /// </summary>
    /// <remarks>
    /// Multiple results can be updated simultaneously by providing the relevant &#x60;result_ids&#x60; in the body of your request. The response will tell you whether the batch of updates has either been successful or failed
    /// </remarks>
    /// <param name="bulkResultsBody"> (optional)</param>
    /// <returns>BulkResultResponse</returns>
    public async Task<BulkResultResponse> BulkUpdate(
      BulkResultsBody bulkResultsBody = null
    )
    {
      var result = await Client.SendData<BulkResultResponse>(new HttpMethod("PATCH"), $"/results", bulkResultsBody);
      return result;
    }

    /// <summary>
    /// Write Results
    /// </summary>
    /// <remarks>
    /// Given a &#x60;subject_id&#x60;, &#x60;facet_id&#x60;, &#x60;assessment_point_rank&#x60; and &#x60;assessment_id&#x60; results can be sent to the Platform, along with a &#x60;student_id&#x60;, the &#x60;grade_id&#x60; and (optionally) the &#x60;result_date&#x60;
    /// </remarks>
    /// <param name="resultBody"> (optional)</param>
    /// <returns>List&lt;Result&gt;</returns>
    public async Task<List<Result>> Create(
      ResultBody resultBody = null
    )
    {
      var result = await Client.SendData<List<Result>>(new HttpMethod("POST"), $"/results", resultBody);
      return result;
    }

    /// <summary>
    /// List Results
    /// </summary>
    /// <remarks>
    /// Returns a list of results for the student ID(s) specified by the students parameter
    /// </remarks>
    /// <param name="students">ID(s) of the student(s) as an Integer. Multiple IDs can be separated with a space (so a + URL encoded)</param>
    /// <param name="ifModifiedSince">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="ifNoneMatch">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;Result&gt;</returns>
    public async Task<List<Result>> List(
      List<int?> students, 
      DateTime? ifModifiedSince = null, 
      string ifNoneMatch = null, 
      int? perPage = null, 
      int? page = null
    )
    {
      dynamic args = new ExpandoObject();
      args.students = students;
      args.ifModifiedSince = ifModifiedSince;
      args.ifNoneMatch = ifNoneMatch;
      args.perPage = perPage;
      args.page = page;
      var results = await Client.GetList<Result>($"/results", args);
      return results;
    }

    /// <summary>
    /// Update a Single Result
    /// </summary>
    /// <remarks>
    /// Once a result has been created, it can be updated on the Platform by passing the required field values in the request body. A list of the fields that were changed are returned in the response
    /// </remarks>
    /// <param name="id">Internal identifier of the entity</param>
    /// <param name="resultUpdate"> (optional)</param>
    /// <returns>Result</returns>
    public async Task<Result> Update(
      int? id, 
      ResultUpdate resultUpdate = null
    )
    {
      var result = await Client.SendData<Result>(new HttpMethod("PATCH"), $"/results/{id}", resultUpdate);
      return result;
    }

  }

  public partial class ApiClient
  {
    public ResultsResource Results => new ResultsResource(this);
  }
}
