namespace DataAccess.Configurations
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Domain;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class MeasurementUnitConfiguration : EntityConfiguration<MeasurementUnit>
	{
		protected override void ConfigureRules(EntityTypeBuilder<MeasurementUnit> builder)
		{
			builder.Property(x => x.Unit).HasMaxLength(5);
			builder.HasKey(x => x.Id);
			builder.HasIndex(x => x.Unit).IsUnique();
		}
	}
}
