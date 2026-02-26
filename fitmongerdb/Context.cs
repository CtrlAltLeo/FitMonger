using Microsoft.EntityFrameworkCore;

public class AppContext : DbContext
{

    public DbSet<Test> Tests { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost:5432;Database=fitmongerdb;Username=user;Password=pass");
    }

}