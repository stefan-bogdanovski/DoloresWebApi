namespace Implementation.UseCases.Commands
{
	
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Application.Exceptions;
	using Application.UseCases.Commands;
	using Application.UseCases.Dto;
	using DataAccess;
	using Domain;
	using FluentValidation;
	using Implementation.UseCases.Validators;

	public class EFCreateOrderCommand : EFUseCaseBase, ICreateOrderCommand
	{
		private readonly CreateOrderValidator _validator;
		public EFCreateOrderCommand(DoloresContext context, CreateOrderValidator validator) : base(context)
		{
			this._validator = validator;
		}

		public int Id => 19;

		public string Name => "Create Order Command";

		public void Execute(InsertOrderDto request)
		{
			foreach(var a in request.OrderlineIds)
			{
				Console.WriteLine(a);
			}
			_validator.ValidateAndThrow(request);
			using var transaction =  this.Context.Database.BeginTransaction();
			this.Context.Add(new Order
			{
				PaymentMethodId = request.PaymentMethodId,
				Date = DateTime.UtcNow,
				Address = request.Address,
				CreditCardNumber = request.CreditCard,
				CardType = request.CardType,
				CVV = request.CVV
			});
			this.Context.SaveChanges();

			var addedOrderId = this.Context.Orders.Max(x => x.Id);
			foreach(var orderlineId in request.OrderlineIds)
			{
				var orderline = this.Context.Orderlines.Find(orderlineId);
				if(orderline == null)
				{
					throw new EntityNotFoundException("Orderline", orderlineId);
				}
				orderline.OrderId = addedOrderId;
				orderline.UpdatedAt = DateTime.UtcNow;
				this.Context.Orderlines.Attach(orderline);
				this.Context.Entry(orderline).Property(x => x.OrderId).IsModified = true;
				this.Context.Entry(orderline).Property(x => x.UpdatedAt).IsModified = true;
			}
			this.Context.SaveChanges();
			transaction.Commit();
			transaction.Dispose();
		}
	}
}
