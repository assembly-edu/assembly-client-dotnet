/**
 * Assembly Developer API .NET Client
 * SDK Version 2.2.473
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
  public class StudentsResource : Resource
  {
    public StudentsResource(ApiClient client)
      : base(client)
    {
    }

    /// <summary>
    /// View a Student
    /// </summary>
    /// <remarks>
    /// Returns an individual student record for the given ID.  **Note:** the response shown includes student demographics, contacts, student SEN needs, student addresses, photo and student care data but these will only be present if you have permission to access it and pass &#x60;demographics&#x60;, &#x60;contacts&#x60;, &#x60;sen_needs&#x60;, &#x60;addresses&#x60;, &#x60;photo&#x60;, &#x60;care&#x60; and &#x60;ever_in_care&#x60; respectively.  ### Photo Notes When requesting photo information the response includes a &#x60;photo.url&#x60; property, this URL should be treated as confidential and used to download the students photo to your storage system of choice. The URL is *not designed for hotlinking directly in the browser* for end users. URLs are signed and only valid for 1 hour after which time you will receive a 400 error.  Once downloaded to avoid repeatedly syncing unchanged photos you should code your application to compare the &#x60;photo.hash&#x60; property to detect changes in student photos since your last sync, it is guaranteed that changes in a photo will change the hash, however the hash is only intended to be used to detect photo changes and is not guaranteed to match a checksum of the files contents.  Photos are currently provided on an \&quot;as is\&quot; basis straight from the source MIS, this means the format, quality, metadata and dimensions are not guaranteed. We reserve the right to normalise this data in the future but your application should be resistant to differing photo formats. 
    /// </remarks>
    /// <param name="id">Internal identifier of the entity</param>
    /// <param name="demographics">Include demographics data (optional)</param>
    /// <param name="contacts">Include contacts data (optional)</param>
    /// <param name="senNeeds">Include SEN needs data (optional)</param>
    /// <param name="emails">Include email addresses (optional)</param>
    /// <param name="addresses">Include address data (optional)</param>
    /// <param name="care">Include student care data (you must also supply the demographics parameter) (optional)</param>
    /// <param name="everInCare">Include whether the student has ever been in care (you must also supply the demographics parameter) (optional)</param>
    /// <param name="languages">Include student language data (optional)</param>
    /// <param name="photo">Include student photo data (optional)</param>
    /// <returns>Student</returns>
    public async Task<Student> Find(
      int? id, 
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
      args.demographics = demographics;
      args.contacts = contacts;
      args.senNeeds = senNeeds;
      args.emails = emails;
      args.addresses = addresses;
      args.care = care;
      args.everInCare = everInCare;
      args.languages = languages;
      args.photo = photo;
      var result = await Client.GetObject<Student>($"/students/{id}", args);
      return result;
    }

    /// <summary>
    /// List Left Students
    /// </summary>
    /// <remarks>
    /// Returns a list of students who have left the school
    /// </remarks>
    /// <param name="ifModifiedSince">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="date">Filter by a specific date, used as the &#x60;start_date&#x60; and &#x60;end_date&#x60; where applicable (optional)</param>
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
    public async Task<List<Student>> Left(
      DateTime? ifModifiedSince = null, 
      DateTime? date = null, 
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
      args.date = date;
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
      var results = await Client.GetList<Student>($"/students/left", args);
      return results;
    }

    /// <summary>
    /// List Students
    /// </summary>
    /// <remarks>
    /// Returns a list of students for the school associated with the provided &#x60;access_token&#x60;
    /// </remarks>
    /// <param name="ifModifiedSince">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="ifNoneMatch">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="students">ID(s) of the student(s) as an Integer. Multiple IDs can be separated with a space (so a + URL encoded) (optional)</param>
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
    public async Task<List<Student>> List(
      DateTime? ifModifiedSince = null, 
      string ifNoneMatch = null, 
      List<int?> students = null, 
      DateTime? date = null, 
      string yearCode = null, 
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
      args.students = students;
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
      var results = await Client.GetList<Student>($"/students", args);
      return results;
    }

  }

  public partial class ApiClient
  {
    public StudentsResource Students => new StudentsResource(this);
  }
}
