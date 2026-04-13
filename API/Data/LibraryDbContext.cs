using Catalogue;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class LibraryDbContext : DbContext
{
    public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
    {
        
    }

    public DbSet<Post> Posts { get; set; }
}