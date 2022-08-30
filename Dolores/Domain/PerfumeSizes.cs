namespace Domain
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class PerfumeSizes : Entity
	{ 
		public int PerfumeId { get; set; }
		public int SizeId { get; set; }
		public int Quantity { get; set; }
		public string ImagePath { get; set; }

		public virtual Perfume Perfume { get; set; }
		public virtual Size Size { get; set; }
		public virtual Pricelist Pricelist { get; set; }
	}
}
