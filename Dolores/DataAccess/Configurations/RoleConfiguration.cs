namespace DataAccess.Configurations
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Domain;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class RoleConfiguration : EntityConfiguration<Role>
	{
		protected override void ConfigureRules(EntityTypeBuilder<Role> builder)
		{
			builder.Property(x => x.Name).IsRequired().HasMaxLength(40);
		}
	}
}
