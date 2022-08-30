namespace DataAccess.Configurations
{
	using Domain;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class OrderlineConfiguration : IEntityTypeConfiguration<Orderline>
	{
		public void Configure(EntityTypeBuilder<Orderline> builder)
		{
			builder.HasKey(c => c.Id);
			builder.Property(x => x.Quantity).IsRequired();

			builder.HasOne(x => x.Pricelist)
				.WithMany(y => y.Orderlines)
				.HasForeignKey(y => y.PricelistId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasOne(x => x.Order)
				.WithMany(x => x.Orderlines)
				.HasForeignKey(x => x.OrderId)
				.OnDelete(DeleteBehavior.Cascade);

			builder.HasOne(x => x.User)
				.WithMany(x => x.Orderlines)
				.HasForeignKey(x => x.UserId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
