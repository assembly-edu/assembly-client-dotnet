using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class Facets : Resource
	{
		public Facets(ApiClient client)
			: base(client)
		{

		}

		public async Task<List<Facet>> Index(
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.perPage = perPage;
			args.page = page;

			var results = await Client.GetList<Facet>("/facets", args);

			return results;
		}

		public async Task<Facet> Show(
		  int? id
		)
		{
			dynamic args = new ExpandoObject();

			var result = await Client.GetObject<Facet>($"/facets/{id}", args);

			return result;
		}

	}

	public partial class ApiClient
	{
		public Facets Facets => new Facets(this);
	}
}
