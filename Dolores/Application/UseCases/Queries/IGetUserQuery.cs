namespace Application.UseCases.Queries
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Application.UseCases.Dto;

	public interface IGetUserQuery : IQuery<int, PresentUserDto>
	{

	}
}
