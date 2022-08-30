namespace Application.UseCases.Dto
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class PresentPerfumeDto : DtoBase
	{
		public string Name { get; set; }
		public string Brand { get; set; }
		public List<PresentPerfumeDtoProperties> Properties { get; set; }
	}
	public class PresentPerfumeDtoProperties
	{
		public string Size { get; set; }
		public int Quantity { get; set; }
		public string Price { get; set; }
		public string Discount { get; set; }
	}
}
