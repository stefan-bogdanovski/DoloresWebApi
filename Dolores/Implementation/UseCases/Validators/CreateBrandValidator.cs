namespace Implementation.UseCases.Validators
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Application.UseCases.Dto;
	using DataAccess;
	using FluentValidation;

	public class CreateBrandValidator : AbstractValidator<InsertBrandDto>
	{
		public CreateBrandValidator(DoloresContext context)
		{
			RuleFor(x => x.Name).NotEmpty().WithMessage("Brand name must not be empty.")
				.MaximumLength(70).WithMessage("Brand name must not exceed 70 characters.");
			RuleFor(b => b.Name).Must(name => context.Brands.All(x => x.Name != name)).WithMessage("Brand name {PropertyValue} already exist");
		}
	}
}
