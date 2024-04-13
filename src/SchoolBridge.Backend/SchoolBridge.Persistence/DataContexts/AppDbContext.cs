using Microsoft.EntityFrameworkCore;
using SchoolBridge.Domain.Entities;

namespace SchoolBridge.Persistence.DataContexts;

public class AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : DbContext(dbContextOptions)
{
    #region School things
    
    public DbSet<Teacher> Teachers => Set<Teacher>();

    public DbSet<Student> Students => Set<Student>();

    public DbSet<School> Schools => Set<School>();

    public DbSet<Class> Classes => Set<Class>();

    public DbSet<Subject> Subjects => Set<Subject>();  

    public DbSet<TeacherSubject> TeacherSubjects => Set<TeacherSubject>();

    #endregion

    #region Identity

    public DbSet<User> Users => Set<User>();

    #endregion

    #region Comments 

    public DbSet<Comment> Comments => Set<Comment>();

    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
