namespace Catalogue;

public class Author
{
    public int Id { get; set; }
    public string Name { get; set; }
    List<Post> Posts { get; set; }
}