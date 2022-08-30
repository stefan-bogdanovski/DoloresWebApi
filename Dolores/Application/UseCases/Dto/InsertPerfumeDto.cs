namespace Application.UseCases.Dto
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class InsertPerfumeDto
	{
		public string Name { get; set; }
		public int BrandId { get; set; }
		public int SizeId { get; set; }
		public int Quantity { get; set; }
		public decimal Price { get; set; }
		public int CurrencyId { get; set; }
		public int Discount { get; set; }
	}
}
