namespace DataAccess.Configurations
{
	using Domain;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class UserUseCaseConfiguration : IEntityTypeConfiguration<UserUseCase>
	{
		public void Configure(EntityTypeBuilder<UserUseCase> builder)
		{
			builder.HasKey(c => new { c.UseCaseId, c.UserId });
		}
	}
}
