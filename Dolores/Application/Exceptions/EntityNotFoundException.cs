namespace Application.Exceptions
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class EntityNotFoundException : Exception
	{
		public EntityNotFoundException(string entityType, int id)
			:base($"Entity of type {entityType} with an Id of {id} was not found.")
		{

		}
	}
}
