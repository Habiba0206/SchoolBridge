using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolBridge.Domain.Entities;

namespace SchoolBridge.Persistence.EntityConfiguration;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder
            .HasOne(student => student.Class)
            .WithMany(@class => @class.Students)
            .HasForeignKey(student => student.ClassId);
    }
}
