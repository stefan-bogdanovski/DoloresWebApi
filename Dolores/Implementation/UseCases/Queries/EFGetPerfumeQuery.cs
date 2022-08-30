namespace Implementation.UseCases.Queries
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Application.Exceptions;
	using Application.UseCases.Dto;
	using Application.UseCases.Dto.Filtering;
	using Application.UseCases.Queries;
	using DataAccess;
	using Microsoft.EntityFrameworkCore;

	public class EFGetPerfumeQuery : EFUseCaseBase, IGetPerfumeQuery
	{
		public EFGetPerfumeQuery(DoloresContext context)
			:base(context)
		{

		}
		public int Id => 11;

		public string Name => "Get Perfume Query";

		public PresentPerfumeDto Execute(int id)
		{
			var perfume = this.Context.Perfumes.Where(perf => perf.IsActive)
				.Where(perf => perf.Id == id)
				.Include(perf => perf.Brand)
				.Include(perf => perf.Sizes)
					.ThenInclude(perfSize => perfSize.Size)
					.ThenInclude(size => size.MeasurementUnit)
				.Include(perf => perf.Sizes)
					.ThenInclude(perfSize => perfSize.Pricelist)
					.ThenInclude(pricelist => pricelist.MoneyCurrency).FirstOrDefault();

			if(perfume == null)
			{
				throw new EntityNotFoundException("Perfume", id);
			}

			var sizeQuantityPriceList = perfume.Sizes.Select(perfSize => new PresentPerfumeDtoProperties
			{
				Price = $"{Math.Round(perfSize.Pricelist.Price - (perfSize.Pricelist.Price * (perfSize.Pricelist.DiscountInPercent / 100)), 2)}{perfSize.Pricelist.MoneyCurrency.Currency}",
				Quantity = perfSize.Quantity,
				Size = $"{perfSize.Size.PerfumeSize}{perfSize.Size.MeasurementUnit.Unit}",
				Discount = $"{perfSize.Pricelist.DiscountInPercent}%"
			}).ToList();

			return new PresentPerfumeDto
			{
				Id = perfume.Id,
				Brand = perfume.Brand.Name,
				Name = perfume.Name,
				Properties = sizeQuantityPriceList,
			};
		}
	}
}
