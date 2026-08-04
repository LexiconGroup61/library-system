using Catalogue;

namespace Application.Models;

public class PersonalBook
{
    public int Id { get; set; }
    public Book Book { get; set; }
    
    public string LibraryUserId { get; set; }
    public LibraryUser User { get; set; }
}