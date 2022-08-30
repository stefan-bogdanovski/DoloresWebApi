using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Exceptions
{
	public class ForbiddenUseCaseExecutionException : Exception
	{
		public ForbiddenUseCaseExecutionException(string useCase, string user) :
			base($"User {user} does not have permission to execute {useCase}.")
		{

		}
	}
}
