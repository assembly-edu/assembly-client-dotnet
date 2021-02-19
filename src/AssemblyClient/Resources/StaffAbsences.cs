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
  public class StaffAbsencesResource : Resource
  {
    public StaffAbsencesResource(ApiClient client)
      : base(client)
    {
    }

    /// <summary>
    /// List Staff Absences
    /// </summary>
    /// <remarks>
    /// Returns a list of staff member absences for the school accociated with the provided &#x60;access_token&#x60;. A school level access token with the &#x60;staff_members.absences&#x60; scope is required to access staff member absence information
    /// </remarks>
    /// <param name="staffMemberId">Filter to the specified staff member (optional)</param>
    /// <param name="startDate">The start date of the period to filter by (optional)</param>
    /// <param name="endDate">The end date of the period to filter by (optional)</param>
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;StaffAbsence&gt;</returns>
    public async Task<List<StaffAbsence>> List(
      int? staffMemberId = null, 
      DateTime? startDate = null, 
      DateTime? endDate = null, 
      int? perPage = null, 
      int? page = null
    )
    {
      dynamic args = new ExpandoObject();
      args.staffMemberId = staffMemberId;
      args.startDate = startDate;
      args.endDate = endDate;
      args.perPage = perPage;
      args.page = page;
      var results = await Client.GetList<StaffAbsence>($"/staff_absences", args);
      return results;
    }

  }

  public partial class ApiClient
  {
    public StaffAbsencesResource StaffAbsences => new StaffAbsencesResource(this);
  }
}
