namespace Domain
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class Orderline : Entity
	{
		public int UserId { get; set; }
		public int PricelistId { get; set; }
		public int Quantity { get; set; }
		public int? OrderId { get; set; }

		public virtual User User { get; set; }
		public virtual Order Order { get; set; }
		public virtual Pricelist Pricelist { get; set; }
	}
}
