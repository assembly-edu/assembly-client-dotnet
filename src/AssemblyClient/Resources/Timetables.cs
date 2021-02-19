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
  public class TimetablesResource : Resource
  {
    public TimetablesResource(ApiClient client)
      : base(client)
    {
    }

    /// <summary>
    /// View a Timetable
    /// </summary>
    /// <remarks>
    /// Returns an individual timetable for the given ID.
    /// </remarks>
    /// <param name="id">Internal identifier of the entity</param>
    /// <param name="date">Filter by a specific date, used as the &#x60;start_date&#x60; and &#x60;end_date&#x60; where applicable (optional)</param>
    /// <param name="startDate">The start date of the period to filter by (optional)</param>
    /// <param name="endDate">The end date of the period to filter by (optional)</param>
    /// <returns>Timetable</returns>
    public async Task<Timetable> Find(
      int? id, 
      DateTime? date = null, 
      DateTime? startDate = null, 
      DateTime? endDate = null
    )
    {
      dynamic args = new ExpandoObject();
      args.date = date;
      args.startDate = startDate;
      args.endDate = endDate;
      var result = await Client.GetObject<Timetable>($"/timetables/{id}", args);
      return result;
    }

    /// <summary>
    /// List Timetables
    /// </summary>
    /// <remarks>
    /// Returns a list of timetables that match the given set of filters.  If a date parameter is provided then the list of groups returned is filtered to only those where the provided date falls between the groups start_date and end_date. Additionally when a date parameter is provided student_ids and supervior_ids are restricted to only those students who were enrolled in the group on the given date. 
    /// </remarks>
    /// <param name="ifModifiedSince">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="ifNoneMatch">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;Timetable&gt;</returns>
    public async Task<List<Timetable>> List(
      DateTime? ifModifiedSince = null, 
      string ifNoneMatch = null, 
      int? perPage = null, 
      int? page = null
    )
    {
      dynamic args = new ExpandoObject();
      args.ifModifiedSince = ifModifiedSince;
      args.ifNoneMatch = ifNoneMatch;
      args.perPage = perPage;
      args.page = page;
      var results = await Client.GetList<Timetable>($"/timetables", args);
      return results;
    }

  }

  public partial class ApiClient
  {
    public TimetablesResource Timetables => new TimetablesResource(this);
  }
}
