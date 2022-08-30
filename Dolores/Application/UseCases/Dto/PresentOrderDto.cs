namespace Application.UseCases.Dto
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class PresentOrderDto : DtoBase
	{
		public int UserId { get; set; }
		public string Username { get; set; }
		public string Email { get; set; }
		public DateTime Date { get; set; }
		public string DeliveryStatus { get; set; }
		public string Address { get; set; }
		public string CreditCard { get; set; }
		public string CVV { get; set; }
		public string CardType { get; set; }
		public string PaymentMethod { get; set; }
		public string TotalCost { get; set; }
		public IEnumerable<PresentOrderlineDto> ProductsOrdered { get; set; }
	}
}
