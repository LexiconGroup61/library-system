using Application.Data;
using Application.Extensions;
using Catalogue;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Application.Controllers;

[ApiController]
[Route("author")]
public class AuthorController(LibraryDbContext db) : ControllerBase
{
  
    [HttpGet]
    public async Task<ActionResult> Index()
    {
        string session = Console.ReadLine() ?? "y";
        string[]? caseTwo = Console.ReadLine()?.Split(" ");
        
        session.MakeUpperCase();
        List<Author> authors = await db.Authors.ToListAsync();
        return Ok("Thing added");
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