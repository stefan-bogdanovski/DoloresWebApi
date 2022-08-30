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

	public class EFCreateOrderlineCommand : EFUseCaseBase, ICreateOrderlineCommand
	{
		private readonly CreateOrderlineValidator _validator;
		public EFCreateOrderlineCommand(DoloresContext context, CreateOrderlineValidator validator)
			:base(context)
		{
			this._validator = validator;
		}

		public int Id => 15;

		public string Name => "Create Orderline Command";

		public void Execute(InsertOrderlineDto request)
		{
			this._validator.ValidateAndThrow(request);

			using var transaction = this.Context.Database.BeginTransaction();

			var orderline = this.Context.Orderlines.Where(o => o.UserId.Equals(request.UserId) && o.PricelistId.Equals(request.PricelistId)).FirstOrDefault();
			if(orderline != null)
			//update quantity
			{
				orderline.Quantity = request.Quantity;
				Context.Orderlines.Attach(orderline);
				Context.Entry(orderline).Property(x => x.Quantity).IsModified = true;
			}
			else
			//add record
			{
				this.Context.Orderlines.Add(new Domain.Orderline
				{
					UserId = request.UserId,
					PricelistId = request.PricelistId,
					Quantity = request.Quantity,
					IsActive = true
				});
			}
			this.Context.SaveChanges();
			transaction.Commit();
			transaction.Dispose();
		}
	}
}
