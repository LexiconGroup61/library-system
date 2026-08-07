using System.Security.Claims;
using Application.Data;
using Application.Models;
using Application.Services.Interfaces;
using Catalogue;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Application;

public static class WebApplicationExtensions
{
    public static void MapEndpoints(this WebApplication app)
    {

        app.MapPost("/user/logout", async (SignInManager<LibraryUser> signInManager, [FromBody] Object empty) =>
            {
                if (empty != null)
                {
                    await signInManager.SignOutAsync();
                    return Results.Ok();
                }
                return Results.Unauthorized();
            })
            .RequireAuthorization();
        app.MapGet("/post", ([FromBody]PostDto newPost, LibraryDbContext db, HttpContext context) =>
        {
            context.Session.GetString("key");
            db.Posts.Add(new Post(newPost));
            db.SaveChanges();
            return "Author added";
        });

        app.MapPost("/fake", (PostDto dto, HttpContext context) =>
        {
            context.Session.SetString("key", "value");
            if (dto.Year > 2022)
            {
                return Results.BadRequest();
            }
            return Results.Created();
        });

        app.MapPost("/post", (PostDto newPost, int directoryid, LibraryDbContext db) =>
        {
            Post post = new Post(newPost);
            post.DirectoryId = directoryid;
            db.Posts.Add(post);
            db.SaveChanges();
            return "Author added";
        });

        app.MapPost("/form", (HttpRequest request) =>
        {
            Console.WriteLine(request.Form["message"]);
            request.Form.Keys.ToList().ForEach(key => Console.WriteLine(key + " " + request.Form[key]));
        });
        
        app.MapPost("/adddate", (int days, LibraryDbContext db) =>
        {
            PublicationDate date = new PublicationDate();
            date.Published = new DateOnly().AddDays(days);
            db.PublicationDates.Add(date);
            db.SaveChanges();
        });

        app.MapPost("/remove", (string message, ICatalogueService service) =>
        {
            service.GetSorted();
        });

        app.MapPost("/author", (Author newAuthor, LibraryDbContext db) =>
        {
            db.Authors.Add(newAuthor);
            db.SaveChanges();
            return "Author added";
        });

        app.MapPut("/post", (Post editedPost, LibraryDbContext db) =>
        {
            var item = db.Posts.FirstOrDefault(p => p.Id == editedPost.Id);
            if (item is Post)
            {
                db.Posts.Update(editedPost);
                db.SaveChanges();
                return "Author added";
            }
            return "Author not added";
        });

        app.MapDelete("/post/{id}", (int id, LibraryDbContext db) =>
        {
            var item = db.Posts.FirstOrDefault(p => p.Id == id);
            db.Posts.Remove(item);
            db.SaveChanges();
            return "Deleted";
        });

        app.MapPost("/title", (Temporary temp) =>
        {
            return $"The title is {temp.Title}";
        });
        
        app.MapGet("/news", (string topic, string category) =>
        {
            string newStuff = "Old stuff" + " and new stuff";
            return newStuff;
        });

        app.MapGet("/savedbooks", (
                LibraryDbContext db,
                HttpContext context,
                UserManager<LibraryUser> manager
            ) =>
            {
                var userId = manager.GetUserId(context.User);

                var books = db.PersonalBooks
                    .Where(p => p.LibraryUserId == userId)
                    .Select(p => new PersonalBookDto(
                        p.Date, p.Creator, p.Publisher, p.Title))
                    .ToList();
      
                
                return Results.Ok(books);
            })
            .RequireAuthorization();
        app.MapPost("/addbook", (
                [FromBody] PersonalBookDto book,
                LibraryDbContext db,
                HttpContext context,
                UserManager<LibraryUser> manager
            ) =>
            {
                var userId = manager.GetUserId(context.User);

                PersonalBook newBook = new PersonalBook(book);
                newBook.LibraryUserId = userId;
                
                db.PersonalBooks.Add(newBook);
                db.SaveChanges();

                return Results.Ok();
            })
            .RequireAuthorization();

        
        app.MapGet("/about/{text}/{number}", ([FromQuery]string text, int number) => $"A site for code – {text} {number}");

        app.MapGet("/", () => "Hello World!");

        app.MapGet("home/privacy", () =>
        {
            return "Privacy enabled";
        }).RequireAuthorization();
    }

    public static void UseCustomMiddleware(this WebApplication app)
    {
        app.Use(async (context, next) =>
        {
            Console.WriteLine("First action above");
            await next.Invoke(context);
            Console.WriteLine("First action below");
        });

        app.Use(async (context, next) =>
        {
            Console.WriteLine("Second action above");
            await next.Invoke(context);
            Console.WriteLine("Second action below");
        });
    }
}