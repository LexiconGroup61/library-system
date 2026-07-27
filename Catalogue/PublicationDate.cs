namespace Catalogue;

public class PublicationDate
{
    public int Id { get; set; }
    public DateOnly Published { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; } = null!;
}