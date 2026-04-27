using API.Data;
using Catalogue;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("author")]
public class AuthorController(LibraryDbContext db) : ControllerBase
{
  
    [HttpGet]
    public string Index()
    {
        List<Author> authors = db.Authors.ToList();
        return "Temporary";
    }

    [HttpPost("new")]
    public string Index(AuthorDto newAuthor)
    {
        if (!ModelState.IsValid)
        {
            Console.WriteLine("Bad request");
        }
   
        return "Temporary";
    }
}