namespace DataAccess.Configurations
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Domain;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class PricelistConfiguration : EntityConfiguration<Pricelist>
	{
		protected override void ConfigureRules(EntityTypeBuilder<Pricelist> builder)
		{
			builder.Property(x => x.Date).IsRequired();
			builder.Property(x => x.PerfumeSizeId).IsRequired();
			builder.HasIndex(x => x.PerfumeSizeId).IsUnique();
			builder.Property(x => x.Price).IsRequired();

			builder.HasOne(x => x.MoneyCurrency)
				.WithMany(x => x.Pricelist)
				.HasForeignKey(y => y.CurrencyId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
