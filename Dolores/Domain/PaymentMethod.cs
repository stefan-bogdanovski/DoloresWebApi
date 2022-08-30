namespace Domain
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class PaymentMethod : Entity
	{
		public string Method { get; set; }

		public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
	}
}
