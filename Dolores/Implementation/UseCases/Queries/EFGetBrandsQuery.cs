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

	public class EFGetBrandsQuery : EFUseCaseBase, IGetBrandsQuery
	{
		public EFGetBrandsQuery(DoloresContext context)
			:base(context)
		{

		}
		public int Id => 5;

		public string Name => "Get brands";

		public IEnumerable<BrandDto> Execute(BaseSearch search)
		{
			var query = this.Context.Brands.Where(b => b.IsActive).Include(x => x.Perfumes.Where(x => x.IsActive)).ThenInclude(y => y.Sizes).AsQueryable();

			if(!string.IsNullOrEmpty(search.Keyword))
			{
				query = query.Where(x => x.Name.Contains(search.Keyword));
			}
			return query.Select(x => new BrandDto
			{
				Id = x.Id,
				Name = x.Name,
				PerfumeCount = x.Perfumes
				.Where(p => p.BrandId == x.Id)
				.SelectMany(x => x.Sizes).Sum(s => s.Quantity)
			}).ToList();
		}
	}
}
