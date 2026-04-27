namespace Catalogue;

public class PublicationDate
{
    public int Id { get; set; }
    public DateOnly Published { get; set; }
    public Book? BookId { get; set; }
}