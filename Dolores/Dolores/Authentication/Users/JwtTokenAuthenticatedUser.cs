namespace Dolores.Authentication.Users
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;
	using Domain;

	public class JwtTokenAuthenticatedUser : IApplicationUser
	{
		public string Identity { get; set; }

		public int? Id { get; set; }
		public IEnumerable<int> UseCaseIds { get; set; } = new List<int>();
		public string Email { get; set; }
	}
}
