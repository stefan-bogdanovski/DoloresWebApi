namespace DataAccess.Configurations
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Domain;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class LogConfiguration : IEntityTypeConfiguration<Log>
	{
		public void Configure(EntityTypeBuilder<Log> builder)
		{
			builder.HasKey(x => x.Id);
		}
	}
}
