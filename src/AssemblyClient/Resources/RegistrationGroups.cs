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
  public class RegistrationGroupsResource : Resource
  {
    public RegistrationGroupsResource(ApiClient client)
      : base(client)
    {
    }

    /// <summary>
    /// View a Registration Group
    /// </summary>
    /// <remarks>
    /// Returns a list of registration groups that match the given set of filters
    /// </remarks>
    /// <param name="id">Internal identifier of the entity</param>
    /// <param name="date">Filter by a specific date, used as the &#x60;start_date&#x60; and &#x60;end_date&#x60; where applicable (optional)</param>
    /// <returns>RegistrationGroup</returns>
    public async Task<RegistrationGroup> Find(
      int? id, 
      DateTime? date = null
    )
    {
      dynamic args = new ExpandoObject();
      args.date = date;
      var result = await Client.GetObject<RegistrationGroup>($"/registration_groups/{id}", args);
      return result;
    }

    /// <summary>
    /// List Registration Groups
    /// </summary>
    /// <remarks>
    /// Returns a list of registration groups that match the given set of filters.  If a date parameter is provided then the list of groups returned is filtered to only those where the provided date falls between the groups &#x60;start_date&#x60; and &#x60;end_date&#x60;. Additionally when a date parameter is provided &#x60;student_ids&#x60; and &#x60;supervior_ids&#x60; are restricted to only those students who were enrolled in the group on the given date. 
    /// </remarks>
    /// <param name="ifModifiedSince">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="ifNoneMatch">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="yearCode">Filter by school year (optional)</param>
    /// <param name="date">Filter by a specific date, used as the &#x60;start_date&#x60; and &#x60;end_date&#x60; where applicable (optional)</param>
    /// <param name="academicYearId">Include all groups and group memberships from the specified academic year (optional)</param>
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;RegistrationGroup&gt;</returns>
    public async Task<List<RegistrationGroup>> List(
      DateTime? ifModifiedSince = null, 
      string ifNoneMatch = null, 
      int? yearCode = null, 
      DateTime? date = null, 
      int? academicYearId = null, 
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
      args.perPage = perPage;
      args.page = page;
      var results = await Client.GetList<RegistrationGroup>($"/registration_groups", args);
      return results;
    }

    /// <summary>
    /// List Students for Registration Group
    /// </summary>
    /// <remarks>
    /// Returns a list of all the students that are present in the registration group identified by &#x60;group_id&#x60;
    /// </remarks>
    /// <param name="id">Internal identifier of the entity</param>
    /// <param name="ifModifiedSince">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="ifNoneMatch">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
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
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;Student&gt;</returns>
    public async Task<List<Student>> Students(
      int? id, 
      DateTime? ifModifiedSince = null, 
      string ifNoneMatch = null, 
      DateTime? date = null, 
      int? yearCode = null, 
      bool? demographics = null, 
      bool? contacts = null, 
      bool? senNeeds = null, 
      bool? emails = null, 
      bool? addresses = null, 
      bool? care = null, 
      bool? everInCare = null, 
      bool? languages = null, 
      bool? photo = null, 
      int? perPage = null, 
      int? page = null
    )
    {
      dynamic args = new ExpandoObject();
      args.ifModifiedSince = ifModifiedSince;
      args.ifNoneMatch = ifNoneMatch;
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
      args.perPage = perPage;
      args.page = page;
      var results = await Client.GetList<Student>($"/registration_groups/{id}/students", args);
      return results;
    }

  }

  public partial class ApiClient
  {
    public RegistrationGroupsResource RegistrationGroups => new RegistrationGroupsResource(this);
  }
}
