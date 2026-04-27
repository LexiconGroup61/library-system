using Catalogue;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class LibraryDbContext : DbContext
{
    public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
    {
        
    }

    public DbSet<Post> Posts { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<PublicationDate> PublicationDates { get; set; }
}