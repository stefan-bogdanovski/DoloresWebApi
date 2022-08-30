namespace Domain
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class Order
	{
		public int Id { get; set; }
		public DateTime? Date { get; set; }
		public int? PaymentMethodId { get; set; }
		public string DeliveryStatus { get; set; }
		public string Address { get; set; }
		public string CreditCardNumber { get; set; }
		public string CVV { get; set; }
		public string CardType { get; set; }

		public virtual PaymentMethod PaymentMethod { get; set; }
		public virtual ICollection<Orderline> Orderlines { get; set; } = new HashSet<Orderline>();
	} 
}
