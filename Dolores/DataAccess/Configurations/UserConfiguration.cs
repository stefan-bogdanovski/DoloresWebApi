namespace DataAccess.Configurations
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Domain;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class UserConfiguration : EntityConfiguration<User>
	{
		protected override void ConfigureRules(EntityTypeBuilder<User> builder)
		{
			builder.Property(x => x.FirstName).HasMaxLength(40).IsRequired();
			builder.Property(x => x.Username).HasMaxLength(40).IsRequired();
			builder.Property(x => x.LastName).HasMaxLength(60).IsRequired();
			builder.Property(x => x.Email).HasMaxLength(40).IsRequired();

			builder.HasIndex(x => x.Email).IsUnique();

			builder.HasMany(x => x.UseCases).WithOne(x => x.User).HasForeignKey(x => x.UserId);

			builder.HasOne(x => x.Role)
				.WithMany(y => y.User)
				.HasForeignKey(x => x.RoleId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasMany(x => x.Logs)
				.WithOne(x => x.User)
				.HasForeignKey(x => x.UserId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
