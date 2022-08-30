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
	using Microsoft.EntityFrameworkCore;

	public class EFDeleteOrderlineCommand : EFUseCaseBase, IDeleteOrderlineCommand
	{
		public EFDeleteOrderlineCommand(DoloresContext context)
			:base(context)
		{

		}

		public int Id => 16;

		public string Name => "Delete Orderline Command";

		public void Execute(int id)
		{
			var orderline = this.Context.Orderlines.Include(o => o.Order).Where(o => o.Id == id)
															.FirstOrDefault();

			if(orderline == null)
			{
				throw new EntityNotFoundException("Orderline", id);
			}

			if(orderline.OrderId != null)
			{
				throw new UseCaseConflictException("Orderline cannot be deleted because it has been ordered.");
			}

			this.Context.Orderlines.Remove(orderline);
			this.Context.SaveChanges();
		}
	}
}
