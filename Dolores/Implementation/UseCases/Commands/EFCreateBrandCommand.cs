namespace Implementation.UseCases.Commands
{

	using System;
	using System.Collections.Generic;
	using System.Text;
	using Application.UseCases.Commands;
	using Application.UseCases.Dto;
	using DataAccess;
	using FluentValidation;
	using Implementation.UseCases.Validators;

	public class EFCreateBrandCommand : EFUseCaseBase, ICreateBrandCommand
	{
		private readonly CreateBrandValidator _validator;

		public EFCreateBrandCommand(DoloresContext context, CreateBrandValidator validator)
			:base(context)
		{
			this._validator = validator;
		}
		public int Id => 7;

		public string Name => "Create Brand Command";

		public void Execute(InsertBrandDto request)
		{
			this._validator.ValidateAndThrow(request);
			this.Context.Brands.Add(new Domain.Brand
			{
				Name = request.Name
			});
			this.Context.SaveChanges();
		}
	}
}
