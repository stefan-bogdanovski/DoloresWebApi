namespace Application.UseCases.Dto
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class InsertOrderDto
	{
		public string Address { get; set; }
		public string CreditCard { get; set; }
		public string CVV { get; set; }
		public string CardType { get; set; }
		public int PaymentMethodId { get; set; }
		public IEnumerable<int> OrderlineIds { get; set; }
	}
}
