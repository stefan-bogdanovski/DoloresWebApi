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

	public class EFGetBrandQuery : EFUseCaseBase, IGetBrandQuery
	{
		public EFGetBrandQuery(DoloresContext context)
			:base (context)
		{

		}
		public int Id => 6;

		public string Name => "Get Brand";

		public BrandDto Execute(int id)
		{
			var brand = this.Context.Brands.Where(x => x.Id == id && x.IsActive).Include(x => x.Perfumes.Where(x => x.IsActive)).ThenInclude(y => y.Sizes).FirstOrDefault();

			if(brand == null)
			{
				throw new EntityNotFoundException("Brand", id);
			}

			return new BrandDto
			{
				Id = brand.Id,
				Name = brand.Name,
				PerfumeCount = brand.Perfumes
				.Where(p => p.BrandId == brand.Id)
				.SelectMany(x => x.Sizes).Sum(s => s.Quantity)
			};
		}
	}
}
