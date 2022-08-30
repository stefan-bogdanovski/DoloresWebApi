namespace Application.UseCases.Dto.Filtering
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class OrderlineSearch : BaseSearch
	{
		public int UserId { get; set; }
	}
}
