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
  public class RoomsResource : Resource
  {
    public RoomsResource(ApiClient client)
      : base(client)
    {
    }

    /// <summary>
    /// List Closures For a Room
    /// </summary>
    /// <remarks>
    /// Returns a list of room closures for the school associated with the provided &#x60;access_token&#x60;.
    /// </remarks>
    /// <param name="id">Internal identifier of the entity</param>
    /// <param name="date">Filter by a specific date, used as the &#x60;start_date&#x60; and &#x60;end_date&#x60; where applicable (optional)</param>
    /// <param name="startDate">The start date of the period to filter by (optional)</param>
    /// <param name="endDate">The end date of the period to filter by (optional)</param>
    /// <returns>List&lt;Closure&gt;</returns>
    public async Task<List<Closure>> Closures(
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
      var results = await Client.GetList<Closure>($"/rooms/{id}/closures", args);
      return results;
    }

    /// <summary>
    /// View a Room
    /// </summary>
    /// <remarks>
    /// Returns a single room for the school associated with the provided &#x60;access_token&#x60;
    /// </remarks>
    /// <param name="id">Internal identifier of the entity</param>
    /// <param name="date">Filter by a specific date, used as the &#x60;start_date&#x60; and &#x60;end_date&#x60; where applicable (optional)</param>
    /// <param name="startDate">The start date of the period to filter by (optional)</param>
    /// <param name="endDate">The end date of the period to filter by (optional)</param>
    /// <returns>Room</returns>
    public async Task<Room> Find(
      int? id, 
      string date = null, 
      string startDate = null, 
      string endDate = null
    )
    {
      dynamic args = new ExpandoObject();
      args.date = date;
      args.startDate = startDate;
      args.endDate = endDate;
      var result = await Client.GetObject<Room>($"/rooms/{id}", args);
      return result;
    }

    /// <summary>
    /// List Lessons For a Room
    /// </summary>
    /// <remarks>
    /// Returns a list of lessons in a room for the school associated with the provided &#x60;access_token&#x60;.
    /// </remarks>
    /// <param name="id">Internal identifier of the entity</param>
    /// <param name="date">Filter by a specific date, used as the &#x60;start_date&#x60; and &#x60;end_date&#x60; where applicable (optional)</param>
    /// <param name="startDate">The start date of the period to filter by (optional)</param>
    /// <param name="endDate">The end date of the period to filter by (optional)</param>
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;Lesson&gt;</returns>
    public async Task<List<Lesson>> Lessons(
      int? id, 
      DateTime? date = null, 
      DateTime? startDate = null, 
      DateTime? endDate = null, 
      int? perPage = null, 
      int? page = null
    )
    {
      dynamic args = new ExpandoObject();
      args.date = date;
      args.startDate = startDate;
      args.endDate = endDate;
      args.perPage = perPage;
      args.page = page;
      var results = await Client.GetList<Lesson>($"/rooms/{id}/lessons", args);
      return results;
    }

    /// <summary>
    /// List Rooms
    /// </summary>
    /// <remarks>
    /// Returns a list of rooms for the school associated with the provided &#x60;access_token&#x60;.
    /// </remarks>
    /// <param name="ifModifiedSince">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="ifNoneMatch">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;Room&gt;</returns>
    public async Task<List<Room>> List(
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
      var results = await Client.GetList<Room>($"/rooms", args);
      return results;
    }

  }

  public partial class ApiClient
  {
    public RoomsResource Rooms => new RoomsResource(this);
  }
}
