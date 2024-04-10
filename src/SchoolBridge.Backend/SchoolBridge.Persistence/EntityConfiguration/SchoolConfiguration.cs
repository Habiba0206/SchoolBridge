using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolBridge.Domain.Entities;

namespace SchoolBridge.Persistence.EntityConfiguration;

public class SchoolConfiguration : IEntityTypeConfiguration<School>
{
    public void Configure(EntityTypeBuilder<School> builder)
    {
        builder
            .Property(school => school.Name)
            .HasMaxLength(250)
            .IsRequired();

        builder
            .HasMany(school => school.Users)
            .WithOne(user => user.School);
    }
}
