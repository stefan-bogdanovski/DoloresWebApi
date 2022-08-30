
namespace Application.UseCases.Dto
{
	using System;
	using System.Collections.Generic;
	using System.Text;


	public class PresentUserDto : DtoBase
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Role { get; set; }
		public IEnumerable<int> UseCasesAllowed { get; set; }
	}
}
