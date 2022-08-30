namespace Implementation.UseCases.Validators
{
	
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Application.UseCases.Dto;
	using DataAccess;
	using FluentValidation;
	using Microsoft.EntityFrameworkCore;

	public class CreateOrderlineValidator : AbstractValidator<InsertOrderlineDto>
	{
		public CreateOrderlineValidator(DoloresContext context)
		{
			RuleFor(x => x.PricelistId)
				.NotEmpty().WithMessage("PricelistId must exist.")
				.Must(id => context.Pricelists.Any(p => p.Id.Equals(id)))
				.DependentRules(() =>
				{
					int currentStock = 0;
					RuleFor(dto => dto).Must(dto =>
					{
						var pricelist = context.Pricelists.Include(p => p.PerfumeSize).Where(p => p.Id.Equals(dto.PricelistId) && p.IsActive).FirstOrDefault();
						currentStock = pricelist.PerfumeSize.Quantity;
						return pricelist.PerfumeSize.Quantity >= dto.Quantity;
					}).WithMessage(dto => $"We currently do not have {dto.Quantity} perfumes for you. Currently we have {currentStock} perfumes of this type in-stock, we will make sure to resupply with perfumes!");
				})
				.WithMessage("Given PricelistId does not exist.");

			RuleFor(x => x.Quantity)
				.NotEmpty().WithMessage("Quantity must exist.")
				.GreaterThan(0).WithMessage("Quantity must not be 0 or less.");

			RuleFor(x => x.UserId)
				.NotEmpty().WithMessage("UserId must exist.")
				.Must(id => context.Users.Any(u => u.Id.Equals(id)))
				.WithMessage("Given UserId does not exist.");
		}
	}
}
