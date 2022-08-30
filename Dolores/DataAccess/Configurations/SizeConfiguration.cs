namespace DataAccess.Configurations
{
	using Domain;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class SizeConfiguration : EntityConfiguration<Size>
	{
		protected override void ConfigureRules(EntityTypeBuilder<Size> builder)
		{
			builder.Property(x => x.PerfumeSize).IsRequired();
			builder.Property(x => x.MeasurementUnitId).IsRequired();

			builder.HasMany(x => x.Perfumes)
				.WithOne(x => x.Size)
				.HasForeignKey(x => x.SizeId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}