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
  public class AttendancesResource : Resource
  {
    public AttendancesResource(ApiClient client)
      : base(client)
    {
    }

    /// <summary>
    /// List Attendances
    /// </summary>
    /// <remarks>
    /// Returns a list of attendances. By default, attendances are returned from the start to the end of the current week
    /// </remarks>
    /// <param name="ifModifiedSince">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="ifNoneMatch">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="studentId">Filter to the specified student (optional)</param>
    /// <param name="registrationGroupId">ID of a registration group (optional)</param>
    /// <param name="groupId">Filter to the specified group (optional)</param>
    /// <param name="startDate">The start date of the period to filter by (optional)</param>
    /// <param name="endDate">The end date of the period to filter by (optional)</param>
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;Attendance&gt;</returns>
    public async Task<List<Attendance>> List(
      DateTime? ifModifiedSince = null, 
      string ifNoneMatch = null, 
      int? studentId = null, 
      int? registrationGroupId = null, 
      int? groupId = null, 
      DateTime? startDate = null, 
      DateTime? endDate = null, 
      int? perPage = null, 
      int? page = null
    )
    {
      dynamic args = new ExpandoObject();
      args.ifModifiedSince = ifModifiedSince;
      args.ifNoneMatch = ifNoneMatch;
      args.studentId = studentId;
      args.registrationGroupId = registrationGroupId;
      args.groupId = groupId;
      args.startDate = startDate;
      args.endDate = endDate;
      args.perPage = perPage;
      args.page = page;
      var results = await Client.GetList<Attendance>($"/attendances", args);
      return results;
    }

    /// <summary>
    /// List Attendance Summaries
    /// </summary>
    /// <remarks>
    /// Returns a list of attendance summaries
    /// </remarks>
    /// <param name="ifModifiedSince">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="ifNoneMatch">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="studentId">Filter to the specified student (optional)</param>
    /// <param name="registrationGroupId">ID of a registration group (optional)</param>
    /// <param name="groupId">Filter to the specified group (optional)</param>
    /// <param name="academicYearId">Include all groups and group memberships from the specified academic year (optional)</param>
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;AttendanceSummary&gt;</returns>
    public async Task<List<AttendanceSummary>> Summaries(
      DateTime? ifModifiedSince = null, 
      string ifNoneMatch = null, 
      int? studentId = null, 
      int? registrationGroupId = null, 
      int? groupId = null, 
      int? academicYearId = null, 
      int? perPage = null, 
      int? page = null
    )
    {
      dynamic args = new ExpandoObject();
      args.ifModifiedSince = ifModifiedSince;
      args.ifNoneMatch = ifNoneMatch;
      args.studentId = studentId;
      args.registrationGroupId = registrationGroupId;
      args.groupId = groupId;
      args.academicYearId = academicYearId;
      args.perPage = perPage;
      args.page = page;
      var results = await Client.GetList<AttendanceSummary>($"/attendances/summaries", args);
      return results;
    }

  }

  public partial class ApiClient
  {
    public AttendancesResource Attendances => new AttendancesResource(this);
  }
}
