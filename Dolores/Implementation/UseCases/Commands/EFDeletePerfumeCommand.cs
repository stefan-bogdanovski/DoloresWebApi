namespace Implementation.UseCases.Commands
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Application.Exceptions;
	using Application.UseCases.Commands;
	using DataAccess;
	using Microsoft.EntityFrameworkCore;

	public class EFDeletePerfumeCommand : EFUseCaseBase, IDeletePerfumeCommand
	{
		public EFDeletePerfumeCommand(DoloresContext context)
			:base(context)
		{

		}
		public int Id => 13;

		public string Name => "Delete Perfume Command";

		public void Execute(int id)
		{
			var perfume = this.Context.Perfumes.Where(x => x.IsActive)
				.Include(x => x.Brand)
				.Include(x => x.Sizes).ThenInclude(s => s.Pricelist)
				.Where(x => x.Id.Equals(id)).FirstOrDefault();
			
			if(perfume == null)
			{
				throw new EntityNotFoundException("Perfume", id);
			}

			if(perfume.Brand != null)
			{
				throw new UseCaseConflictException("Perfume cannot be deleted because it has relationship with brand.");
			}
			if(perfume.Sizes != null)
			{
				throw new UseCaseConflictException("Perfume cannot be deleted because it has relationship with sizes.");
			}
			if(this.Context.Pricelists.Include(p => p.PerfumeSize).Where(p => p.IsActive).Any(x => x.PerfumeSize.PerfumeId.Equals(id) && x.IsActive))
			{
				throw new UseCaseConflictException("Perfume cannot be deleted because it exists in pricelist.");
			}
		}
	}
}
