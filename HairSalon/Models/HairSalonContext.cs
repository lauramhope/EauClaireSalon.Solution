using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class HairSalonContext : DbContext
  {
    public DbSet<ClassName1> ClassNames1 { get; set; }
    public DbSet<ClassName2> ClassNames2 { get; set; }
 
    public HairSalonContext(DbContextOptions options) : base(options) { }
  }
}