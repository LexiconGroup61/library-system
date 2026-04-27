using System.ComponentModel.DataAnnotations;

namespace Catalogue;



public class Post
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Author { get; set; }
    public string? Publisher { get; set; }
    public int Year { get; set; }

    public int DirectoryId { get; set; }
    public Directory Directory { get; set; }


    
    public Post()
    {
        
    }

    public Post(PostDto dto)
    {
        Author = dto.Author;
        Title = dto.Title;
        Publisher = dto.Publisher;
        Year = dto.Year;
        DirectoryId = 1;
    }
    
    public Post(string author, string title, string publisher, int year)
    {
        Author = author;
        Title = title;
        Publisher = publisher;
        Year = year;
    }
    public int ReturnNumber()
    {
        throw new NotImplementedException();
    }

    public int ReturnNumber(string text, int notUsed)
    {
        string number = Console.ReadLine();
        return int.Parse(number);
    }

    public decimal CalculateCost(decimal price)
    {
        return price * 1.25m;
    }

    public double CalculateArea(double sideA, double sideB)
    {
        return sideA * sideB;
    }


    public bool SetReturnDate(int days)
    {
        throw new NotImplementedException();
    }
}