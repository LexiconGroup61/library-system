namespace Application.Models;

public class Patron
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string LibraryUserId { get; set; }
    public LibraryUser User { get; set; }
}