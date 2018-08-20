using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class Students : Resource
	{
		public Students(ApiClient client)
			: base(client)
		{

		}

		public async Task<List<Student>> Index(
		  DateTime? ifModifiedSince = null, 
		  List<int?> students = null, 
		  DateTime? date = null, 
		  int? yearCode = null, 
		  bool? demographics = null, 
		  bool? contacts = null, 
		  bool? senNeeds = null, 
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
			args.students = students;
			args.date = date;
			args.yearCode = yearCode;
			args.demographics = demographics;
			args.contacts = contacts;
			args.senNeeds = senNeeds;
			args.addresses = addresses;
			args.care = care;
			args.everInCare = everInCare;
			args.languages = languages;
			args.photo = photo;
			args.perPage = perPage;
			args.page = page;

			var results = await Client.GetList<Student>("/students", args);

			return results;
		}

		public async Task<List<Student>> Left(
		  DateTime? ifModifiedSince = null
		)
		{
			dynamic args = new ExpandoObject();
			args.ifModifiedSince = ifModifiedSince;

			var results = await Client.GetList<Student>("/students/left", args);

			return results;
		}

		public async Task<Student> Show(
		  int? id, 
		  bool? demographics = null, 
		  bool? contacts = null, 
		  bool? senNeeds = null, 
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
			args.addresses = addresses;
			args.care = care;
			args.everInCare = everInCare;
			args.languages = languages;
			args.photo = photo;

			var result = await Client.GetObject<Student>($"/students/{id}", args);

			return result;
		}

	}

	public partial class ApiClient
	{
		public Students Students => new Students(this);
	}
}
