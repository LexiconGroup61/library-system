using System.ComponentModel.DataAnnotations;

namespace Catalogue;

public class AuthorBook
{
    [Key]
    public int Id { get; set; }
    public int AuthorId { get; set; }
    public int BookId { get; set; }
}