namespace Application.UseCases.Dto
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class PresentLogDto
	{
		public string UseCaseName { get; set; }
		public int UserId { get; set; }
		public string UserRole { get; set; }
		public DateTime ExecutionTime { get; set; }
		public string Data { get; set; }
	}
}
