using Microsoft.EntityFrameworkCore;

namespace ProjectName.Models
{
  public class ProjectNameContext : DbContext
  {
    public DbSet<ClassName1> ClassNames1 { get; set; }
    public DbSet<ClassName2> ClassNames2 { get; set; }
 
    public ProjectNameContext(DbContextOptions options) : base(options) { }
  }
}