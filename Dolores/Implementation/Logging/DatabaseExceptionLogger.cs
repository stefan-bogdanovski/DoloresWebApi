namespace Implementation.Logging
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Application.UseCases;
	using DataAccess;

	public class DatabaseExceptionLogger : IUseCaseLogger
	{
		private readonly DoloresContext _context;

		public DatabaseExceptionLogger(DoloresContext context)
		{
			_context = context;
		}

		public IEnumerable<UseCaseLog> GetLogs(UseCaseLogSearch search)
		{
			throw new NotImplementedException();
		}

		public void Log(UseCaseLog log)
		{
			this._context.Logs.Add(new Domain.Log
			{
				UseCaseName = log.UseCaseName,
				UserId = log.UserId,
				Data = log.Data,
				ExecutionDateTime = log.ExecutionDateTime
			});
			_context.SaveChanges();
		}
	}
}
