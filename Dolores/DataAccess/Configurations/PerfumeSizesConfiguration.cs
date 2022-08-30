namespace DataAccess.Configurations
{
	using Domain;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class PerfumeSizesConfiguration : IEntityTypeConfiguration<PerfumeSizes>
	{
		public void Configure(EntityTypeBuilder<PerfumeSizes> builder)
		{
			builder.HasKey(c => c.Id);
			builder.Property(x => x.Quantity).IsRequired();

			builder.HasOne(x => x.Pricelist)
				.WithOne(x => x.PerfumeSize)
				.HasForeignKey<Pricelist>(x => x.PerfumeSizeId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
