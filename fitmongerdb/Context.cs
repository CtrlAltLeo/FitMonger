using Microsoft.EntityFrameworkCore;

public class AppContext : DbContext
{

    public DbSet<Test> Tests { get; set; }
    public DbSet<Article> Articles { get; set; }
    public DbSet<ArticleType> ArticleTypes { get; set; }
    public DbSet<BodyRegion> BodyRegions { get; set; }

    public AppContext()
    {
    }

    public AppContext(DbContextOptions<AppContext> options) : base(options)
    {
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost:5432;Database=fitmongerdb;Username=user;Password=pass");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BodyRegion>()
        .HasData(
            new BodyRegion {BodyRegionID = 1,Name = "Head" }, 
            new BodyRegion {BodyRegionID = 2,Name = "Torso" }, 
            new BodyRegion {BodyRegionID = 3,Name = "Legs" },
            new BodyRegion {BodyRegionID = 4,Name = "Feet" },
            new BodyRegion {BodyRegionID = 5,Name = "Arms" },
            new BodyRegion {BodyRegionID = 6,Name = "Neck" }, 
            new BodyRegion {BodyRegionID = 7,Name = "Upper Torso" },
            new BodyRegion {BodyRegionID = 8,Name = "Shins" },
            new BodyRegion {BodyRegionID = 9,Name = "Wrist" }
        );

        modelBuilder.Entity<ArticleType>()
            .HasData(
                new ArticleType {ArticleTypeID = 1, Name = "Shirt", BodyRegionID = 2},
                new ArticleType {ArticleTypeID = 2, Name = "Pants", BodyRegionID = 3},
                new ArticleType {ArticleTypeID = 3, Name = "Shoes", BodyRegionID = 4},
                new ArticleType {ArticleTypeID = 4, Name = "Hat", BodyRegionID = 1},
                new ArticleType {ArticleTypeID = 5, Name = "Gloves", BodyRegionID = 5},
                new ArticleType {ArticleTypeID = 6, Name = "Scarf", BodyRegionID = 6},
                new ArticleType {ArticleTypeID = 7, Name = "Jacket", BodyRegionID = 7},
                new ArticleType {ArticleTypeID = 8, Name = "Socks", BodyRegionID = 8},
                new ArticleType {ArticleTypeID = 9, Name = "Watch", BodyRegionID = 9}
            );

    }

}