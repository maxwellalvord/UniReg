using Microsoft.EntityFrameworkCore;

namespace Reg.Models
{
  public class RegContext : DbContext
  {
    public DbSet<Course> Courses {get; set;}
    public DbSet<Student> Students {get; set;}
    public DbSet<CourseStudent> CourseStudent {get; set;}

    public RegContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}