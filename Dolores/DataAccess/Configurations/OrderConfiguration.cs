namespace DataAccess.Configurations
{
	using Domain;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class OrderConfiguration : IEntityTypeConfiguration<Order>
	{
		public void Configure(EntityTypeBuilder<Order> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Date).IsRequired();
			builder.Property(x => x.Address).IsRequired().HasMaxLength(100);
			builder.Property(x => x.DeliveryStatus).HasDefaultValue("InProcess");
			builder.Property(x => x.CreditCardNumber).HasMaxLength(25);
			builder.Property(x => x.CVV).HasMaxLength(10);

			builder.HasMany(x => x.Orderlines)
				.WithOne(y => y.Order)
				.HasForeignKey(y => y.OrderId)
				.OnDelete(DeleteBehavior.Restrict);
			
			builder.HasOne(x => x.PaymentMethod)
				.WithMany(y => y.Orders)
				.HasForeignKey(x => x.PaymentMethodId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
