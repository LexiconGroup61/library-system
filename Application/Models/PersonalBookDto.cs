namespace Application.Models;

public class PersonalBookDto
{
    public int Id { get; set; }
    public string Date { get; set; }
    public string Creator { get; set; }
    public string Publisher { get; set; }
    public string Title { get; set; }
    
    
    public PersonalBookDto()
    {
        
    }

    public PersonalBookDto(string date, string creator, string publisher, string title)
    {
        Date = date;
        Creator = creator;
        Publisher = publisher;
        Title = title;
    }
}