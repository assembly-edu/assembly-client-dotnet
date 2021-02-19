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
  public class StaffContractsResource : Resource
  {
    public StaffContractsResource(ApiClient client)
      : base(client)
    {
    }

    /// <summary>
    /// List Staff Contracts
    /// </summary>
    /// <remarks>
    /// Returns a list of staff member contracts for the school accociated with the provided &#x60;access_token&#x60;. A school level access token with the &#x60;staff_members.contracts&#x60; scope is required to access staff member contract information
    /// </remarks>
    /// <param name="staffMemberId">Filter to the specified staff member (optional)</param>
    /// <param name="date">Filter by a specific date, used as the &#x60;start_date&#x60; and &#x60;end_date&#x60; where applicable (optional)</param>
    /// <param name="roles">Include role information along with a staff contract (optional)</param>
    /// <param name="salaries">Include salaries information along with a staff contract (requires &#x60;staff_members.salaries&#x60; scope for full information - only the &#x60;hours_per_week&#x60;, &#x60;fte&#x60; and &#x60;weeks_per_year&#x60; fields are shown without it) (optional)</param>
    /// <param name="allowances">Include allowances information along with a staff contract (requires &#x60;staff_members.salaries&#x60; scope) (optional)</param>
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;StaffContract&gt;</returns>
    public async Task<List<StaffContract>> List(
      int? staffMemberId = null, 
      string date = null, 
      bool? roles = null, 
      bool? salaries = null, 
      bool? allowances = null, 
      int? perPage = null, 
      int? page = null
    )
    {
      dynamic args = new ExpandoObject();
      args.staffMemberId = staffMemberId;
      args.date = date;
      args.roles = roles;
      args.salaries = salaries;
      args.allowances = allowances;
      args.perPage = perPage;
      args.page = page;
      var results = await Client.GetList<StaffContract>($"/staff_contracts", args);
      return results;
    }

  }

  public partial class ApiClient
  {
    public StaffContractsResource StaffContracts => new StaffContractsResource(this);
  }
}
