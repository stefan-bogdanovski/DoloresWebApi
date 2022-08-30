namespace Implementation.UseCases.Queries
{
	using Application.UseCases.Dto;
	using Application.UseCases.Dto.Filtering;
	using Application.UseCases.Queries;
	using DataAccess;
	using Microsoft.EntityFrameworkCore;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class EFGetOrdersQuery : EFUseCaseBase, IGetOrdersQuery
	{
		public EFGetOrdersQuery(DoloresContext context)
			:base(context)
		{

		}
		public int Id => 18;

		public string Name => "Get Orders Query";

		public IEnumerable<PresentOrderDto> Execute(BaseSearch search)
		{
			var ordersQuery = this.Context.Orders
				.Include(o => o.Orderlines).ThenInclude(ol => ol.Pricelist).ThenInclude(p => p.PerfumeSize).ThenInclude(ps => ps.Size).ThenInclude(s => s.MeasurementUnit)
				.Include(o => o.Orderlines).ThenInclude(ol => ol.Pricelist).ThenInclude(p => p.PerfumeSize).ThenInclude(ps => ps.Perfume).ThenInclude(p => p.Brand)
				.Include(o => o.Orderlines).ThenInclude(ol => ol.Pricelist).ThenInclude(p => p.MoneyCurrency)
				.Include(o => o.Orderlines).ThenInclude(ol => ol.User)
				.Include(o => o.PaymentMethod).AsQueryable();

			if(!string.IsNullOrEmpty(search.Keyword))
			{
				ordersQuery = ordersQuery
					.Where(o => o.Orderlines.Any(ol => ol.User.FirstName.Contains(search.Keyword)
					|| o.Orderlines.Any(ol => ol.Pricelist.PerfumeSize.Perfume.Name.Contains(search.Keyword))));
			}

			var orders = ordersQuery.Select(o => new PresentOrderDto
			{
				Id = o.Id,
				Address = o.Address,
				CardType = o.CardType,
				CreditCard = o.CreditCardNumber,
				CVV = o.CVV,
				Date = (DateTime)o.Date,
				DeliveryStatus = o.DeliveryStatus,
				Email = o.Orderlines.Where(ol => ol.IsActive).Select(x => x.User.Email).FirstOrDefault(),
				PaymentMethod = o.PaymentMethod.Method,
				UserId = o.Orderlines.Where(ol => ol.IsActive).Select(x => x.UserId).FirstOrDefault(),
				Username = o.Orderlines.Where(ol => ol.IsActive).Select(x => x.User.Username).FirstOrDefault(),
				ProductsOrdered = o.Orderlines.Select(x => new PresentOrderlineDto
					{
						Name = x.Pricelist.PerfumeSize.Perfume.Name,
						Brand = x.Pricelist.PerfumeSize.Perfume.Brand.Name,
						Price = EFGetOrderlinesQuery.CalculatePrice(x.Quantity, x.Pricelist.Price, x.Pricelist.DiscountInPercent),
						Currency = x.Pricelist.MoneyCurrency.Currency,
						Quantity = x.Quantity,
						Size = $"{x.Pricelist.PerfumeSize.Size.PerfumeSize}{x.Pricelist.PerfumeSize.Size.MeasurementUnit.Unit}"
					}).ToList(),
			}).ToList();

			foreach(var order in orders)
			{
				order.TotalCost = $"{order.ProductsOrdered.Sum(x => x.Price)}{order.ProductsOrdered.FirstOrDefault().Currency}";
			}
			return orders;
		}
	}
}
