namespace Implementation.UseCases.Queries
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Application.Exceptions;
	using Application.UseCases.Dto;
	using Application.UseCases.Dto.Filtering;
	using Application.UseCases.Queries;
	using DataAccess;
	using Microsoft.EntityFrameworkCore;

	public class EFGetUserQuery : EFUseCaseBase, IGetUserQuery
	{
		public EFGetUserQuery(DoloresContext context)
			: base(context)
		{

		}

		public int Id => 3;

		public string Name => "Get user query";

		public PresentUserDto Execute(int id)
		{
			var user = this.Context.Users.Include(user => user.Role).Include(u => u.UseCases).Where(x => x.Id == id).FirstOrDefault();
			if(user == null)
			{
				throw new EntityNotFoundException("User", id);
			}
			return new PresentUserDto
			{
				Id = id,
				FirstName = user.FirstName,
				LastName = user.LastName,
				Role = user.Role.Name,
				UseCasesAllowed = user.UseCases.Select(x => x.UseCaseId)
			};
		}
	}
}
