namespace Implementation.UseCases.Commands
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Application.UseCases.Commands;
	using Application.UseCases.Dto;
	using BCrypt.Net;
	using DataAccess;
	using Domain;
	using FluentValidation;
	using Implementation.UseCases.Validations;

	public class EFRegisterUserCommand : EFUseCaseBase, IRegisterUserCommand
	{
		private readonly CreateUserValidator _validator;
		private const int AuthorizedUserRoleId = 2;

		public EFRegisterUserCommand(DoloresContext context, CreateUserValidator validator)
			:base(context)
		{
			_validator = validator;
		}

		public int Id => 2;

		public string Name => "Register user";

		public void Execute(RegisterUserDto request)
		{
			_validator.ValidateAndThrow(request);

			var userUsesCases = new HashSet<UserUseCase>();
			foreach (var useCase in request.UseCases)
			{
				userUsesCases.Add(new UserUseCase { UseCaseId = useCase });
			}

			var userToAdd = new User
			{
				FirstName = request.FirstName,
				LastName = request.LastName,
				Username = request.Username,
				Email = request.Email,
				Password = BCrypt.HashPassword(request.Password),
				RoleId = AuthorizedUserRoleId,
				UseCases = userUsesCases
			};
			this.Context.Users.Add(userToAdd);			

			this.Context.SaveChanges();
		}		
	}
}
