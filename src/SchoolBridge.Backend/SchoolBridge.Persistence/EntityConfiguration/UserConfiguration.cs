using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolBridge.Domain.Entities;
using SchoolBridge.Domain.Enums;

namespace SchoolBridge.Persistence.EntityConfiguration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder
            .Property(user => user.FirstName)
            .HasMaxLength(60)
            .IsRequired(true);

        builder
            .Property(user => user.LastName)
            .HasMaxLength(60)
            .IsRequired(true);

        builder
            .Property(user => user.PhoneNumber)
            .HasMaxLength(13)
            .IsRequired(true);

        builder
            .HasOne(user => user.School)
            .WithMany(school => school.Users)
            .HasForeignKey(user => user.SchoolId);

        builder.ToTable("Users")
            .HasDiscriminator(user => user.Role)
            .HasValue<Teacher>(Role.Teacher)
            .HasValue<Student>(Role.Student);
    }
}
