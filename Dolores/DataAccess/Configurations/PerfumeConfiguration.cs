namespace DataAccess.Configurations
{
	using System;
	using Domain;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class PerfumeConfiguration : EntityConfiguration<Perfume>
	{
		protected override void ConfigureRules(EntityTypeBuilder<Perfume> builder)
		{
			builder.Property(x => x.Name).IsRequired().HasMaxLength(70);
			builder.HasIndex(x => x.Name).IsUnique();
			builder.HasOne(x => x.Brand).WithMany(y => y.Perfumes);

			builder.HasMany(x => x.Sizes)
				.WithOne(y => y.Perfume)
				.HasForeignKey(y => y.PerfumeId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
