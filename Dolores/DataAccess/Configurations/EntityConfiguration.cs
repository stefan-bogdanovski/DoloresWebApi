namespace DataAccess.Configurations
{
	using Domain;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;
	using System;
	using System.Collections.Generic;
	using System.Text;

	public abstract class EntityConfiguration<T> : IEntityTypeConfiguration<T>
		where T : Entity
	{
		public void Configure(EntityTypeBuilder<T> builder)
		{
			builder.Property(x => x.IsActive).HasDefaultValue(true);
			builder.Property(x => x.CreatedAt).HasDefaultValueSql("getdate()");
			builder.Property(x => x.UpdatedBy).HasMaxLength(50);
			builder.Property(x => x.DeletedBy).HasMaxLength(50);

			ConfigureRules(builder);
		}

		protected abstract void ConfigureRules(EntityTypeBuilder<T> builder);
	}
}
