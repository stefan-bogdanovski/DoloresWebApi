namespace Domain
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class MoneyCurrency : Entity
	{
		public string Currency { get; set; }

		public virtual ICollection<Pricelist> Pricelist { get; set; } = new HashSet<Pricelist>();
	}
}
