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
  public class GroupsResource : Resource
  {
    public GroupsResource(ApiClient client)
      : base(client)
    {
    }

    /// <summary>
    /// View a Group
    /// </summary>
    /// <remarks>
    /// Returns a list of groups that match the given set of filters
    /// </remarks>
    /// <param name="id">Internal identifier of the entity</param>
    /// <param name="date">Filter by a specific date, used as the &#x60;start_date&#x60; and &#x60;end_date&#x60; where applicable (optional)</param>
    /// <returns>Group</returns>
    public async Task<Group> Find(
      int? id, 
      DateTime? date = null
    )
    {
      dynamic args = new ExpandoObject();
      args.date = date;
      var result = await Client.GetObject<Group>($"/groups/{id}", args);
      return result;
    }

    /// <summary>
    /// List Groups
    /// </summary>
    /// <remarks>
    /// Returns a list of groups that match the given set of filters.  If a date parameter is provided then the list of groups returned is filtered to only those where the provided date falls between the groups &#x60;start_date&#x60; and &#x60;end_date&#x60;. Additionally when a date parameter is provided &#x60;student_ids&#x60; and &#x60;supervior_ids&#x60; are restricted to only those students who were enrolled in the group on the given date. 
    /// </remarks>
    /// <param name="ifModifiedSince">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="ifNoneMatch">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="yearCode">Filter by school year (optional)</param>
    /// <param name="date">Filter by a specific date, used as the &#x60;start_date&#x60; and &#x60;end_date&#x60; where applicable (optional)</param>
    /// <param name="academicYearId">Include all groups and group memberships from the specified academic year (optional)</param>
    /// <param name="type">Filter by type (optional)</param>
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;Group&gt;</returns>
    public async Task<List<Group>> List(
      DateTime? ifModifiedSince = null, 
      string ifNoneMatch = null, 
      string yearCode = null, 
      DateTime? date = null, 
      int? academicYearId = null, 
      string type = null, 
      int? perPage = null, 
      int? page = null
    )
    {
      dynamic args = new ExpandoObject();
      args.ifModifiedSince = ifModifiedSince;
      args.ifNoneMatch = ifNoneMatch;
      args.yearCode = yearCode;
      args.date = date;
      args.academicYearId = academicYearId;
      args.type = type;
      args.perPage = perPage;
      args.page = page;
      var results = await Client.GetList<Group>($"/groups", args);
      return results;
    }

    /// <summary>
    /// List Group Enrolments
    /// </summary>
    /// <remarks>
    /// Returns a list of group enrolments that match the given set of filters.  If a date parameter is provided then the list of group enrolments returned is filtered to only those where the provided date falls between the groups &#x60;start_date&#x60; and &#x60;end_date&#x60;. If an &#x60;academic_year_id&#x60; is supplied all enrolments are returned. 
    /// </remarks>
    /// <param name="ifModifiedSince">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="ifNoneMatch">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="groups">ID(s) of the group(s) as an Integer. Multiple IDs can be separated with a space (so a + URL encoded) (optional)</param>
    /// <param name="date">Filter by a specific date, used as the &#x60;start_date&#x60; and &#x60;end_date&#x60; where applicable (optional)</param>
    /// <param name="academicYearId">Include all groups and group memberships from the specified academic year (optional)</param>
    /// <returns>List&lt;Enrolment&gt;</returns>
    public async Task<List<Enrolment>> List_0(
      DateTime? ifModifiedSince = null, 
      string ifNoneMatch = null, 
      List<int?> groups = null, 
      DateTime? date = null, 
      int? academicYearId = null
    )
    {
      dynamic args = new ExpandoObject();
      args.ifModifiedSince = ifModifiedSince;
      args.ifNoneMatch = ifNoneMatch;
      args.groups = groups;
      args.date = date;
      args.academicYearId = academicYearId;
      var results = await Client.GetList<Enrolment>($"/groups/enrolments", args);
      return results;
    }

    /// <summary>
    /// List Students for Group
    /// </summary>
    /// <remarks>
    /// Returns a list of all the students that are present in the group identified by &#x60;group_id&#x60;
    /// </remarks>
    /// <param name="id">Internal identifier of the entity</param>
    /// <param name="ifModifiedSince">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="ifNoneMatch">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="academicYearId">Include all groups and group memberships from the specified academic year (optional)</param>
    /// <param name="date">Filter by a specific date, used as the &#x60;start_date&#x60; and &#x60;end_date&#x60; where applicable (optional)</param>
    /// <param name="yearCode">Filter by school year (optional)</param>
    /// <param name="demographics">Include demographics data (optional)</param>
    /// <param name="contacts">Include contacts data (optional)</param>
    /// <param name="senNeeds">Include SEN needs data (optional)</param>
    /// <param name="emails">Include email addresses (optional)</param>
    /// <param name="addresses">Include address data (optional)</param>
    /// <param name="care">Include student care data (you must also supply the demographics parameter) (optional)</param>
    /// <param name="everInCare">Include whether the student has ever been in care (you must also supply the demographics parameter) (optional)</param>
    /// <param name="languages">Include student language data (optional)</param>
    /// <param name="photo">Include student photo data (optional)</param>
    /// <returns>List&lt;Student&gt;</returns>
    public async Task<List<Student>> List_1(
      int? id, 
      DateTime? ifModifiedSince = null, 
      string ifNoneMatch = null, 
      int? academicYearId = null, 
      string date = null, 
      string yearCode = null, 
      bool? demographics = null, 
      bool? contacts = null, 
      bool? senNeeds = null, 
      bool? emails = null, 
      bool? addresses = null, 
      bool? care = null, 
      bool? everInCare = null, 
      bool? languages = null, 
      bool? photo = null
    )
    {
      dynamic args = new ExpandoObject();
      args.ifModifiedSince = ifModifiedSince;
      args.ifNoneMatch = ifNoneMatch;
      args.academicYearId = academicYearId;
      args.date = date;
      args.yearCode = yearCode;
      args.demographics = demographics;
      args.contacts = contacts;
      args.senNeeds = senNeeds;
      args.emails = emails;
      args.addresses = addresses;
      args.care = care;
      args.everInCare = everInCare;
      args.languages = languages;
      args.photo = photo;
      var results = await Client.GetList<Student>($"/groups/{id}/students", args);
      return results;
    }

  }

  public partial class ApiClient
  {
    public GroupsResource Groups => new GroupsResource(this);
  }
}
