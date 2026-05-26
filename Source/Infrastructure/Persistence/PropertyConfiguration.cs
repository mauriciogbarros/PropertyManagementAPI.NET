
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class PropertyConfiguration : IEntityTypeConfiguration<Property>
{
	public void Configure(EntityTypeBuilder<Property> builder)
	{
		builder.HasKey(p => p.Id);

		builder.OwnsOne(p => p.Info, infoBuilder =>
		{
			infoBuilder.Property(i => i.WebPage).HasMaxLength(200);
		});

		// Explicitly tell EF Core to use the backing fields for these navigations
		builder.Navigation(p => p.Units)
			.UsePropertyAccessMode(PropertyAccessMode.Field);
		builder.Navigation(p => p.Users)
			.UsePropertyAccessMode(PropertyAccessMode.Field);

		// Define the One-to-Many relationships
		// Units
		builder.HasMany(p => p.Units)
			.WithOne()
			.HasForeignKey("PropertyId")
			.OnDelete(DeleteBehavior.Cascade);

		// Users
		builder.HasMany(p => p.Users)
			.WithOne()
			.HasForeignKey("PropertyId")
			.OnDelete(DeleteBehavior.Cascade);
	}
}