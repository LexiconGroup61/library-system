using Microsoft.EntityFrameworkCore;

namespace Catalogue.Data;

public class CatalogueDbContext : DbContext
{
    public CatalogueDbContext()
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=catalogue.db");
    }

    public DbSet<Post> Posts { get; set; }
    public DbSet<Author> Authors { get; set; }
}