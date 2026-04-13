using Microsoft.EntityFrameworkCore;

namespace Catalogue.Data;

public class CatalogueDbContext : DbContext
{
    public string DbPath { get; set; }
    public CatalogueDbContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=catalogueAltB.db");
    }

    public DbSet<Post> Posts { get; set; }
    public DbSet<Author> Authors { get; set; }
}