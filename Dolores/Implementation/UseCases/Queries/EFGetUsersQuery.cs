namespace Implementation.UseCases.Queries
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Application.UseCases.Dto;
	using Application.UseCases.Dto.Filtering;
	using Application.UseCases.Queries;
	using DataAccess;
	using Microsoft.EntityFrameworkCore;

	public class EFGetUsersQuery : EFUseCaseBase, IGetUsersQuery
	{
		public EFGetUsersQuery(DoloresContext context)
			:base(context)
		{

		}

		public int Id => 1;

		public string Name => "Get users query";

		public IEnumerable<PresentUserDto> Execute(BaseSearch search)
		{
			var users = this.Context.Users.Where(u => u.IsActive).Include(user => user.Role).Include(u => u.UseCases).AsQueryable();
			if(!string.IsNullOrEmpty(search.Keyword))
			{
				users = users.Where(u => u.FirstName.Contains(search.Keyword) || u.LastName.Contains(search.Keyword));
			}

			return users.Select(x => new PresentUserDto
			{
				Id = x.Id,
				FirstName = x.FirstName,
				LastName = x.LastName,
				Role = x.Role.Name,
				UseCasesAllowed = x.UseCases.Select(x => x.UseCaseId)
			}).ToList();
		}
	}
}
