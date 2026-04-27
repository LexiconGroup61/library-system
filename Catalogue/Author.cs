namespace Catalogue;

public class Author
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<string> Titles { get; set; }
    public List<int> Sales { get; set; }
    public List<Post> Posts { get; set; }
    public List<Book> Books { get; set; }

    public Author()
    {
        
    }

    public Author(string name)
    {
        Name = name;
    }
}