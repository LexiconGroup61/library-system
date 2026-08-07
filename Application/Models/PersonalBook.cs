using System.Text.Json.Serialization;
using Catalogue;

namespace Application.Models;

public class PersonalBook
{
    public int Id { get; set; }
    public string Date { get; set; }
    public string Creator { get; set; }
    public string Publisher { get; set; }
    public string Title { get; set; }

    public string LibraryUserId { get; set; }

    public LibraryUser User { get; set; }

    public PersonalBook()
    {
        
    }

    public PersonalBook(string date, string creator, string publisher, string title)
    {
        Date = date;
        Creator = creator;
        Publisher = publisher;
        Title = title;
    }
    
    public PersonalBook(PersonalBookDto dto)
    {
        Date = dto.Date;
        Creator = dto.Creator;
        Publisher = dto.Publisher;
        Title = dto.Title;
    }
}