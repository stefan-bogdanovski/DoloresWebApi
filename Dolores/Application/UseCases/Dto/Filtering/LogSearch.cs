namespace Application.UseCases.Dto.Filtering
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class LogSearch
	{
		public string UseCaseName { get; set; }
		public int UserId { get; set; }
		public DateTime? From { get; set; }
		public DateTime? To { get; set; }
		public string DataKeyword { get; set; }
	}
}
