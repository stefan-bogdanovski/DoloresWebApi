namespace Application.UseCases.Queries
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Application.UseCases.Dto;
	using Application.UseCases.Dto.Filtering;

	public interface IGetLogsQuery : IQuery<LogSearch, IEnumerable<PresentLogDto>>
	{
	}
}
