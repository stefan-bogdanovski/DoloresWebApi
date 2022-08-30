namespace Application.UseCases.Commands
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Application.UseCases.Dto;

	public interface ICreateOrderCommand : ICommand<InsertOrderDto>
	{
	}
}
