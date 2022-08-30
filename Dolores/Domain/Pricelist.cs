namespace Domain
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class Pricelist : Entity
	{
		public int PerfumeSizeId { get; set; }
		public decimal Price { get; set; }
		public DateTime Date { get; set; }
		public int DiscountInPercent { get; set; }
		public int CurrencyId { get; set; }

		public virtual MoneyCurrency MoneyCurrency { get; set; }
		public virtual PerfumeSizes PerfumeSize { get; set; }
		public virtual ICollection<Orderline> Orderlines { get; set; } = new HashSet<Orderline>();
	}
}
