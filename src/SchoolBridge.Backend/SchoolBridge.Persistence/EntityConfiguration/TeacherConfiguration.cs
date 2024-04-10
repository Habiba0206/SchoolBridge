using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolBridge.Domain.Entities;

namespace SchoolBridge.Persistence.EntityConfiguration;

public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        builder
            .HasOne(teacher => teacher.Class)
            .WithOne(@class => @class.HeadTeacher)
            .HasForeignKey<Teacher>(teacher => teacher.ClassId);

        builder
            .HasMany(teacher => teacher.Subjects)
            .WithMany(subject => subject.Teachers)
            .UsingEntity<TeacherSubject>(teacherSubject =>
            {
                teacherSubject.HasKey(relation =>
                new
                {
                    relation.TeacherId,
                    relation.SubjectId
                });

                teacherSubject.ToTable("TeacherSubjects");
            });
    }
}
