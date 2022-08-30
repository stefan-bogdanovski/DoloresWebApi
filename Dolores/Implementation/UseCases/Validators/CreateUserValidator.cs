namespace Implementation.UseCases.Validations
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Application.UseCases.Dto;
	using DataAccess;
	using FluentValidation;

	public class CreateUserValidator : AbstractValidator<RegisterUserDto>
	{
		public CreateUserValidator(DoloresContext context)
		{
			RuleFor(x => x.Username)
				.NotEmpty().WithMessage("Property username must not be empty.")
				.MaximumLength(40).WithMessage("Property username exceeds the 40 characters limit.")
				.Must(x => context.Users.All(user => !user.Username.Equals(x)))
				.WithMessage("Username has been already taken.");

			RuleFor(x => x.Email)
				.NotEmpty().WithMessage("Property email must not be empty")
				.MaximumLength(40).WithMessage("Property email exceeds the 40 characters limit.")
				.Must(x => context.Users.All(user => !user.Email.Equals(x)))
				.WithMessage("Email has been already registered.");

			RuleFor(x => x.FirstName)
				.NotEmpty().WithMessage("Property first name must not be empty.")
				.MaximumLength(40).WithMessage("Property first name exceeds 40 characters limit.");

			RuleFor(x => x.LastName)
				.NotEmpty().WithMessage("Property last name must not be empty.")
				.MaximumLength(40).WithMessage("Property last name exceeds 40 characters limit.");

			RuleFor(x => x.Password).NotEmpty().WithMessage("Password must not be empty.")
				.MinimumLength(8).WithMessage("Password must have at least 8 characters.");

			RuleFor(x => x.UseCases)
				.NotEmpty().WithMessage("User must have at least one use case to execute.")
				.DependentRules(() =>
				{
					RuleFor(x => x.UseCases).ForEach(useCase =>
					{
						useCase.Must(x => context.UserUseCases.Any(useCase => useCase.UseCaseId == x)).WithMessage("Provided use case id {PropertyValue} does not exist.");

					});
				});
		}
	}
}
