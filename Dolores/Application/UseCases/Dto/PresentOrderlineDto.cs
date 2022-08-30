namespace Application.UseCases.Dto
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class PresentOrderlineDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Brand { get; set; }
		public int Quantity { get; set; }
		public string Size { get; set; }
		public decimal Price { get; set; }
		public string Currency { get; set; }
	}
}
