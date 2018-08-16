using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class StaffContracts : Resource
	{
		public StaffContracts(ApiClient client)
			: base(client)
		{

		}


		public async Task<List<StaffMember>> List(
		  int? staffMemberId = null, 
		  bool? date = null, 
		  bool? roles = null, 
		  bool? salaries = null, 
		  bool? allowances = null, 
		  DateTime? ifModifiedSince = null, 
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.staffMemberId = staffMemberId;
			args.date = date;
			args.roles = roles;
			args.salaries = salaries;
			args.allowances = allowances;
			args.ifModifiedSince = ifModifiedSince;
			args.perPage = perPage;
			args.page = page;

			var results = await Client.GetList<StaffMember>("/staff_contracts", args);

			return results;
		}

	}

	public partial class ApiClient
	{
		public StaffContracts StaffContracts => new StaffContracts(this);
	}
}
