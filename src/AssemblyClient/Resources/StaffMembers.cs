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
  public class StaffMembersResource : Resource
  {
    public StaffMembersResource(ApiClient client)
      : base(client)
    {
    }

    /// <summary>
    /// View a Staff Member
    /// </summary>
    /// <remarks>
    /// Returns an individual staff member record for the given ID
    /// </remarks>
    /// <param name="id">Internal identifier of the entity</param>
    /// <param name="addresses">Include address data (optional)</param>
    /// <param name="demographics">Include demographics data (optional)</param>
    /// <param name="qualifications">Include HLTA status, QT status, QT route and previous degree information (requires &#x60;staff_members.qualifications&#x60; scope) (optional)</param>
    /// <returns>StaffMember</returns>
    public async Task<StaffMember> Find(
      int? id, 
      bool? addresses = null, 
      bool? demographics = null, 
      bool? qualifications = null
    )
    {
      dynamic args = new ExpandoObject();
      args.addresses = addresses;
      args.demographics = demographics;
      args.qualifications = qualifications;
      var result = await Client.GetObject<StaffMember>($"/staff_members/{id}", args);
      return result;
    }

    /// <summary>
    /// List Left Staff Members
    /// </summary>
    /// <remarks>
    /// Returns a list of staff members who have left the school
    /// </remarks>
    /// <param name="ifModifiedSince">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="ifNoneMatch">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="teachersOnly">Filter to staff who are teachers (optional)</param>
    /// <param name="addresses">Include address data (optional)</param>
    /// <param name="demographics">Include demographics data (optional)</param>
    /// <param name="qualifications">Include HLTA status, QT status, QT route and previous degree information (requires &#x60;staff_members.qualifications&#x60; scope) (optional)</param>
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;StaffMember&gt;</returns>
    public async Task<List<StaffMember>> Left(
      DateTime? ifModifiedSince = null, 
      string ifNoneMatch = null, 
      bool? teachersOnly = null, 
      bool? addresses = null, 
      bool? demographics = null, 
      bool? qualifications = null, 
      int? perPage = null, 
      int? page = null
    )
    {
      dynamic args = new ExpandoObject();
      args.ifModifiedSince = ifModifiedSince;
      args.ifNoneMatch = ifNoneMatch;
      args.teachersOnly = teachersOnly;
      args.addresses = addresses;
      args.demographics = demographics;
      args.qualifications = qualifications;
      args.perPage = perPage;
      args.page = page;
      var results = await Client.GetList<StaffMember>($"/staff_members/left", args);
      return results;
    }

    /// <summary>
    /// List Staff Members
    /// </summary>
    /// <remarks>
    /// Returns a list of staff members for the school accociated with the provided &#x60;access_token&#x60;
    /// </remarks>
    /// <param name="ifModifiedSince">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="ifNoneMatch">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="teachersOnly">Filter to staff who are teachers (optional)</param>
    /// <param name="addresses">Include address data (optional)</param>
    /// <param name="demographics">Include demographics data (optional)</param>
    /// <param name="qualifications">Include HLTA status, QT status, QT route and previous degree information (requires &#x60;staff_members.qualifications&#x60; scope) (optional)</param>
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;StaffMember&gt;</returns>
    public async Task<List<StaffMember>> List(
      DateTime? ifModifiedSince = null, 
      string ifNoneMatch = null, 
      bool? teachersOnly = null, 
      bool? addresses = null, 
      bool? demographics = null, 
      bool? qualifications = null, 
      int? perPage = null, 
      int? page = null
    )
    {
      dynamic args = new ExpandoObject();
      args.ifModifiedSince = ifModifiedSince;
      args.ifNoneMatch = ifNoneMatch;
      args.teachersOnly = teachersOnly;
      args.addresses = addresses;
      args.demographics = demographics;
      args.qualifications = qualifications;
      args.perPage = perPage;
      args.page = page;
      var results = await Client.GetList<StaffMember>($"/staff_members", args);
      return results;
    }

  }

  public partial class ApiClient
  {
    public StaffMembersResource StaffMembers => new StaffMembersResource(this);
  }
}
