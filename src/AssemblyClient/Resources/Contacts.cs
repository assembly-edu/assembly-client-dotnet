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
  public class ContactsResource : Resource
  {
    public ContactsResource(ApiClient client)
      : base(client)
    {
    }

    /// <summary>
    /// List Contacts
    /// </summary>
    /// <remarks>
    /// Returns a list of contacts that match the given set of filters
    /// </remarks>
    /// <param name="studentId">Filter to the specified student (optional)</param>
    /// <param name="addresses">Include address data (optional)</param>
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;Contact&gt;</returns>
    public async Task<List<Contact>> List(
      int? studentId = null, 
      bool? addresses = null, 
      int? perPage = null, 
      int? page = null
    )
    {
      dynamic args = new ExpandoObject();
      args.studentId = studentId;
      args.addresses = addresses;
      args.perPage = perPage;
      args.page = page;
      var results = await Client.GetList<Contact>($"/contacts", args);
      return results;
    }

  }

  public partial class ApiClient
  {
    public ContactsResource Contacts => new ContactsResource(this);
  }
}
