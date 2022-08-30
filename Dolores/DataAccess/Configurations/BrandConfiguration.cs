namespace DataAccess.Configurations
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Domain;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class BrandConfiguration : EntityConfiguration<Brand>
	{
		protected override void ConfigureRules(EntityTypeBuilder<Brand> builder)
		{
			builder.Property(x => x.Name).IsRequired().HasMaxLength(70);

			builder.HasMany(x => x.Perfumes)
				.WithOne(y => y.Brand)
				.HasForeignKey(x => x.BrandId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
