namespace Implementation.UseCases.Commands
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Application.UseCases.Commands;
	using Application.UseCases.Dto;
	using DataAccess;
	using FluentValidation;
	using Implementation.UseCases.Validators;

	public class EFCreatePerfumeCommand : EFUseCaseBase, ICreatePerfumeCommand
	{
		private readonly CreatePerfumeValidator _validator;
		public EFCreatePerfumeCommand(DoloresContext context, CreatePerfumeValidator validator)
			:base(context)
		{
			this._validator = validator;
		}
		public int Id => 12;

		public string Name => "Create Perfume Command";

		public void Execute(InsertPerfumeDto request)
		{
			this._validator.ValidateAndThrow(request);

			using var transaction = this.Context.Database.BeginTransaction();

			this.Context.Perfumes.Add(new Domain.Perfume
			{
				BrandId = request.BrandId,
				Name = request.Name,
			});
			this.Context.SaveChanges();

			var addedPerfumeId = this.Context.Perfumes.Max(x => x.Id);

			this.Context.PerfumeSizes.Add(new Domain.PerfumeSizes
			{
				PerfumeId = addedPerfumeId,
				SizeId = request.SizeId,
				Quantity = request.Quantity
			});
			this.Context.SaveChanges();

			var addedPerfumeSizeId = this.Context.PerfumeSizes.Max(x => x.Id);
			this.Context.Pricelists.Add(new Domain.Pricelist
			{
				PerfumeSizeId = addedPerfumeSizeId,
				Price = request.Price,
				CurrencyId = request.CurrencyId,
				DiscountInPercent = request.Discount,
				Date = DateTime.UtcNow
			});
			this.Context.SaveChanges();
			transaction.Commit();
			transaction.Dispose();
		}
	}
}
