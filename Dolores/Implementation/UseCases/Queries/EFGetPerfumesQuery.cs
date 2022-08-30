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

	public class EFGetPerfumesQuery : EFUseCaseBase, IGetPerfumesQuery
	{
		public EFGetPerfumesQuery(DoloresContext context)
			:base(context)
		{

		}

		public int Id => 10;

		public string Name => "Get Perfumes Query";

		public IEnumerable<PresentPerfumeDto> Execute(BaseSearch search)
		{
			var perfumesQuery = this.Context.Perfumes.Where(perf => perf.IsActive)
				.Include(perf => perf.Brand)
				.Include(perf => perf.Sizes)
					.ThenInclude(perfSize => perfSize.Size)
					.ThenInclude(size => size.MeasurementUnit)
				.Include(perf => perf.Sizes)
					.ThenInclude(perfSize => perfSize.Pricelist)
					.ThenInclude(pricelist => pricelist.MoneyCurrency).AsQueryable();

			if(!string.IsNullOrEmpty(search.Keyword))
			{
				perfumesQuery = perfumesQuery.Where(x => x.Name.Contains(search.Keyword) || x.Brand.Name.Contains(search.Keyword));
			}
			var perfumes = perfumesQuery.ToList();

			return perfumes.Select(perf => new PresentPerfumeDto
			{
				Id = perf.Id,
				Brand = perf.Brand.Name,
				Name = perf.Name,
				Properties = perf.Sizes.Select(perfSize => new PresentPerfumeDtoProperties
				{
					Price = $"{Math.Round(perfSize.Pricelist.Price - (perfSize.Pricelist.Price * (perfSize.Pricelist.DiscountInPercent / 100)), 2)}{perfSize.Pricelist.MoneyCurrency.Currency}",
					Quantity = perfSize.Quantity,
					Size = $"{perfSize.Size.PerfumeSize}{perfSize.Size.MeasurementUnit.Unit}",
					Discount = $"{perfSize.Pricelist.DiscountInPercent}%"
				}).ToList()
		}).ToList();
		}
	}
}
