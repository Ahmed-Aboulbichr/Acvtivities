using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    // public internal void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
    //     optionsBuilder.EnableThreadSafetyChecks(false);
    // }

    public DbSet<Activity> Activities { get; set; }

}