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
  public class MedicalConditionsResource : Resource
  {
    public MedicalConditionsResource(ApiClient client)
      : base(client)
    {
    }

    /// <summary>
    /// View a Medical Condition
    /// </summary>
    /// <remarks>
    /// Returns a single medical condition for the given ID
    /// </remarks>
    /// <param name="id">Internal identifier of the entity</param>
    /// <returns>MedicalCondition</returns>
    public async Task<MedicalCondition> Find(
      int? id
    )
    {
      dynamic args = new ExpandoObject();
      var result = await Client.GetObject<MedicalCondition>($"/school/medical_conditions/{id}", args);
      return result;
    }

    /// <summary>
    /// List Medical Conditions
    /// </summary>
    /// <remarks>
    /// Returns a list of all the Medical Conditions defined by the school
    /// </remarks>
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;MedicalCondition&gt;</returns>
    public async Task<List<MedicalCondition>> List(
      int? perPage = null, 
      int? page = null
    )
    {
      dynamic args = new ExpandoObject();
      args.perPage = perPage;
      args.page = page;
      var results = await Client.GetList<MedicalCondition>($"/school/medical_conditions", args);
      return results;
    }

  }

  public partial class ApiClient
  {
    public MedicalConditionsResource MedicalConditions => new MedicalConditionsResource(this);
  }
}
