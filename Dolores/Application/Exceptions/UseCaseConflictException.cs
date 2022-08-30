namespace Application.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class UseCaseConflictException : Exception
    {
        public UseCaseConflictException(string message) : base(message)
        {

        }
    }
}
