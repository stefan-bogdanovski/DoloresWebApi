namespace Application.UseCases.Dto
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class InsertOrderlineDto
	{
		public int PricelistId { get; set; }
		public int Quantity { get; set; }
		public int UserId { get; set; }
	}
}
