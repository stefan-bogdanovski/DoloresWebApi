namespace Implementation.UseCases
{ 
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Application.UseCases.Dto;
	using DataAccess;

	public abstract class EFUseCaseBase
	{
		protected DoloresContext Context { get; }

		protected EFUseCaseBase(DoloresContext context)
		{
			this.Context = context;
		}
	}
}
