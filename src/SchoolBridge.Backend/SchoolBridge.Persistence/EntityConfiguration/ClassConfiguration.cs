using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolBridge.Domain.Entities;

namespace SchoolBridge.Persistence.EntityConfiguration;

public class ClassConfiguration : IEntityTypeConfiguration<Class>
{
    public void Configure(EntityTypeBuilder<Class> builder)
    {
        builder
            .Property(@class => @class.Name)
            .HasMaxLength(50)
            .IsRequired(true);

        builder
            .HasOne(@class => @class.HeadTeacher)
            .WithOne(teacher => teacher.Class)
            .HasForeignKey<Class>(c => c.HeadTeacherId);
    }
}
