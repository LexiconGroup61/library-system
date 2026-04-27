using System.ComponentModel.DataAnnotations;

namespace Catalogue;

public class PostDto
{
    
    public int Id { get; set; }
    [Required]
    public string? Title { get; set; } 
    
    [Required]
    public string? Author { get; set; }
    public string? Publisher { get; set; }
    public int Year { get; set; }

}