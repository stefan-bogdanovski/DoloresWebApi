namespace Application.UseCases
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public interface ICommand<TRequest> : IUseCase
	{
		public void Execute(TRequest request);
	}
}
