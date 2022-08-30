namespace Implementation
{
    using System;
	using System.Collections.Generic;
	using System.Diagnostics;
	using System.Linq;
	using System.Text;
    using Application.Exceptions;
    using Application.UseCases;
    using Domain;
    using Newtonsoft.Json;

    public class UseCaseHandler
	{
        private IApplicationUser _user;
        private IUseCaseLogger _useCaseLogger;

        public UseCaseHandler(
            IApplicationUser user,
            IUseCaseLogger useCaseLogger)
        {
            _user = user;
            _useCaseLogger = useCaseLogger;
        }

        public void HandleCommand<TRequest>(ICommand<TRequest> command, TRequest data)
		{
            HandleLoggingAndAuthorization(command, data);
            command.Execute(data);
        }

        public TResponse HandleQuery<TRequest, TResponse>(IQuery<TRequest, TResponse> query, TRequest data)
        {
            HandleLoggingAndAuthorization(query, data);
            return query.Execute(data);
        }

        private void HandleLoggingAndAuthorization<TRequest>(IUseCase useCase, TRequest data)
        {
            var isAuthorized = _user.UseCaseIds.Contains(useCase.Id);

            var log = new UseCaseLog
            {
                User = _user.Identity,
                ExecutionDateTime = DateTime.UtcNow,
                UseCaseName = useCase.Name,
                UserId = _user.Id,
                Data = JsonConvert.SerializeObject(data),
                IsAuthorized = isAuthorized
            };

            _useCaseLogger.Log(log);

            if (!isAuthorized)
            {
                throw new ForbiddenUseCaseExecutionException(useCase.Name, _user.Identity);
            }
        }
    }
}
