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

	public class EFGetLogsQuery : EFUseCaseBase, IGetLogsQuery
	{
		public EFGetLogsQuery(DoloresContext context)
			:base(context)
		{

		}

		public int Id => 17;

		public string Name => "Get Logs Query";

		public IEnumerable<PresentLogDto> Execute(LogSearch search)
		{
			var query = this.Context.Logs.Include(l => l.User).ThenInclude(u => u.Role).AsQueryable();
			if(search.UserId != 0)
			{
				query = query.Where(l => l.UserId.Equals(search.UserId));
			}
			if(!string.IsNullOrEmpty(search.UseCaseName))
			{
				query = query.Where(l => l.UseCaseName.Equals(search.UseCaseName));
			}
			if(search.From != null)
			{
				if(search.From != null && search.To != null && search.From > search.To)
				{
					var temp = search.From;
					search.From = search.To;
					search.To = temp;
				}
				query = query.Where(l => l.ExecutionDateTime >= search.From);
			}
			if(search.To != null)
			{
				if (search.From != null && search.To != null && search.From > search.To)
				{
					var temp = search.From;
					search.From = search.To;
					search.To = temp;
				}
				query = query.Where(l => l.ExecutionDateTime <= search.From);
			}
			if(!string.IsNullOrEmpty(search.DataKeyword))
			{
				query = query.Where(l => l.Data.Contains(search.DataKeyword));
			}

			return query.Select(x => new PresentLogDto
			{
				Data = x.Data,
				UserId = x.UserId ?? 0,
				UseCaseName = x.UseCaseName,
				ExecutionTime = x.ExecutionDateTime,
				UserRole = x.User.Role.Name
			}).ToList();
		}
	}
}
