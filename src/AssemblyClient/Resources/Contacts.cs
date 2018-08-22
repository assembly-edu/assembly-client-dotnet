using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class Contacts : Resource
	{
		public Contacts(ApiClient client)
			: base(client)
		{

		}

		public async Task<List<Contact>> List(
		  int? studentId = null, 
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.studentId = studentId;
			args.perPage = perPage;
			args.page = page;

			var results = await Client.GetList<Contact>("/contacts", args);

			return results;
		}

	}

	public partial class ApiClient
	{
		public Contacts Contacts => new Contacts(this);
	}
}
