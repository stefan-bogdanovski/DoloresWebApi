namespace Dolores.Authentication.Users
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;
	using Domain;

	public class AnonymousUser : IApplicationUser
	{
		public string Identity => "Anonymous";

		public int? Id => null;


		public IEnumerable<int> UseCaseIds => new List<int> { 6, 5, 11, 10, 3, 1, 2 };

		public string Email => "Unknown_user@asp-api.com";
	}
}
