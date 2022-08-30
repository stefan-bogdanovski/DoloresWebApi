namespace Application.UseCases
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public interface IQuery<TSearch, TResult> : IUseCase
	{
		TResult Execute(TSearch search);
	}
}
