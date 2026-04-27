namespace Catalogue;

public class Book
{
    public int Id { get; set; }
    public List<Author> Authors { get; set; }
    public string Title { get; set; }
    public PublicationDate PublishedOn { get; set; }
}