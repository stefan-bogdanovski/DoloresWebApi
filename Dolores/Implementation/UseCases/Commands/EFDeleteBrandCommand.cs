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

	public class EFDeleteBrandCommand : EFUseCaseBase, IDeleteBrandCommand
	{
		public EFDeleteBrandCommand(DoloresContext context)
			:base(context)
		{

		}
		public int Id => 8;

		public string Name => "Delete Brand";

		public void Execute(int request)
		{
			var brand = Context.Brands.Include(x => x.Perfumes).FirstOrDefault(x => x.Id == request && x.IsActive);

			if(brand == null)
			{
				throw new EntityNotFoundException("brand", request);
			}

			if(brand.Perfumes.Any())
			{
				throw new UseCaseConflictException("Brand cannot be deleted because it has relationship with perfumes.");
			}

			brand.IsActive = false;
			brand.DeletedAt = DateTime.UtcNow;
			Context.Brands.Attach(brand);
			Context.Entry(brand).Property(x => x.IsActive).IsModified = true;
			Context.Entry(brand).Property(x => x.DeletedAt).IsModified = true;
			Context.SaveChanges();
		}
	}
}
