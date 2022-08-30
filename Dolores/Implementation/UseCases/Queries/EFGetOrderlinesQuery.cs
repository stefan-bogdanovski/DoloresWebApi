namespace Implementation.UseCases.Queries
{

	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Application.UseCases.Dto;
	using Application.UseCases.Dto.Filtering;
	using Application.UseCases.Queries;
	using DataAccess;
	using Microsoft.EntityFrameworkCore;

	public class EFGetOrderlinesQuery : EFUseCaseBase, IGetOrderlinesQuery
	{
		public EFGetOrderlinesQuery(DoloresContext context)
			:base(context)
		{

		}

		public int Id => 14;

		public string Name => "Get Orderlines Query";

		public IEnumerable<PresentOrderlineDto> Execute(OrderlineSearch search)
		{
			var query = this.Context.Orderlines.Where(o => o.OrderId == null)
				.Include(o => o.Pricelist).ThenInclude(p => p.PerfumeSize).ThenInclude(ps => ps.Perfume).ThenInclude(p => p.Brand)
				.Include(o => o.Pricelist).ThenInclude(p => p.PerfumeSize).ThenInclude(ps => ps.Size).ThenInclude(s => s.MeasurementUnit)
				.Include(o => o.Pricelist).ThenInclude(p => p.MoneyCurrency).AsQueryable();

			if (!string.IsNullOrEmpty(search.Keyword))
			{
				query = query.Where(o => o.Pricelist.PerfumeSize.Perfume.Name.Equals(search.Keyword) ||
				o.Pricelist.PerfumeSize.Perfume.Brand.Name.Equals(search.Keyword));
			}
			if(search.UserId != 0)
			{
				query = query.Where(o => o.UserId.Equals(search.UserId));
			}

			return query.Select(x => new PresentOrderlineDto
			{
				Id = x.Id,
				Name = x.Pricelist.PerfumeSize.Perfume.Name,
				Brand = x.Pricelist.PerfumeSize.Perfume.Brand.Name,
				Price = CalculatePrice(x.Quantity, x.Pricelist.Price, x.Pricelist.DiscountInPercent),
				Currency = x.Pricelist.MoneyCurrency.Currency,
				Quantity = x.Quantity,
				Size = $"{x.Pricelist.PerfumeSize.Size.PerfumeSize}{x.Pricelist.PerfumeSize.Size.MeasurementUnit.Unit}"
			}).ToList();

		}
		public static decimal CalculatePrice(int quantity, decimal price, int discount)
		{
			var newPrice = price - ((price * discount) / 100);
			return Math.Round(newPrice * quantity, 2);
		}
	}
}
