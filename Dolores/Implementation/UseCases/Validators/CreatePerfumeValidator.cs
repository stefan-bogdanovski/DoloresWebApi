namespace Implementation.UseCases.Validators
{

	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Application.UseCases.Dto;
	using DataAccess;
	using FluentValidation;
	using Newtonsoft.Json;

	public class CreatePerfumeValidator : AbstractValidator<InsertPerfumeDto>
	{
		public CreatePerfumeValidator(DoloresContext context)
		{
			RuleFor(x => x.Name)
				.NotEmpty().WithMessage("Perfume name must not be empty.")
				.MaximumLength(70).WithMessage("Perfume name must not exceed 70 characters.")
				.Must(x => context.Perfumes.All(p => !p.Name.Equals(x)))
				.WithMessage("Perfume name already exist.");

			RuleFor(x => x.BrandId)
				.NotEmpty().WithMessage("Brand Id must not be empty.")
				.Must(x => context.Brands.Any(brand => brand.Id.Equals(x)))
				.WithMessage("Brand Id {PropertyValue} does not exist.");

			RuleFor(x => x.SizeId)
				.NotEmpty().WithMessage("Size Id must not be empty.")
				.Must(x => context.Sizes.Any(size => size.Id.Equals(x)))
				.WithMessage("Size Id {PropertyValue} does not exist.");

			RuleFor(x => x.Quantity)
				.NotEmpty().WithMessage("Quantity must not be empty.")
				.GreaterThan(0).WithMessage("Quantity must be a positive whole number.");

			RuleFor(x => x.Price)
				.NotEmpty().WithMessage("Price must not be empty.")
				.GreaterThanOrEqualTo((decimal)0.1).WithMessage("Price must be greater than or equal to 0.1 currency.");

			RuleFor(x => x.CurrencyId)
				.NotEmpty().WithMessage($"CurrencyId must not be empty. Available currencies are {JsonConvert.SerializeObject(context.MoneyCurrencies.Select(x => new { x.Id, x.Currency }).ToList())}")
				.Must(x => context.MoneyCurrencies.Any(y => y.Id.Equals(x)))
				.WithMessage($"CurrencyId not allowed. Please take a look at the available currency id list. {JsonConvert.SerializeObject(context.MoneyCurrencies.Select(x => new { x.Id,  x.Currency }).ToList())}");
			
			RuleFor(x => x.Discount).GreaterThanOrEqualTo(0).WithMessage("Discount must not be less than 0%");
		}
	}
}
