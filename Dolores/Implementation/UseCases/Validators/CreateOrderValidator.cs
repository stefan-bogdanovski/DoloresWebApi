namespace Implementation.UseCases.Validators
{

	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Application.UseCases.Dto;
	using DataAccess;
	using FluentValidation;

	public class CreateOrderValidator :  AbstractValidator<InsertOrderDto>
	{
		public CreateOrderValidator(DoloresContext context)
		{
			RuleFor(x => x.Address).NotEmpty().WithMessage("Address must not be empty.");
			RuleFor(x => x.PaymentMethodId).NotEmpty().WithMessage("PaymentMethodId must not be empty.")
				.When(x => x.PaymentMethodId
				.Equals(context.PaymentMethods.Where(p => p.Method.Equals("Online")).Select( pm => pm.Id).FirstOrDefault()))
				.DependentRules(() =>
				{
					RuleFor(x => x.CreditCard).NotEmpty().WithMessage("CreditCard must not be empty.");
					RuleFor(x => x.CardType).NotEmpty().WithMessage("CardType must not be empty.");
					RuleFor(x => x.CVV).NotEmpty().WithMessage("CVV must not be empty.");
				});
			int currentId = 0;
			RuleFor(x => x.OrderlineIds).NotEmpty().WithMessage("At least one orderline must be provided.")
				.Must(list =>
				{
					return list.All(oneOrderLine =>
					{
						currentId = oneOrderLine;
						return context.Orderlines.Any(ol => ol.IsActive && ol.OrderId == null && ol.Id.Equals(oneOrderLine));
					});
				}).WithMessage($"Orderline with an Id {currentId} does not exist.");
		}
	}
}
