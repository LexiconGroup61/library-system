using Application.Data;
using Application.Services.Interfaces;
using Catalogue;
using Microsoft.AspNetCore.Mvc;

namespace Application;

public static class WebApplicationExtensions
{
    public static void MapEndpoints(this WebApplication app)
    {
        app.MapGet("/post", ([FromBody]PostDto newPost, LibraryDbContext db) =>
        {
            db.Posts.Add(new Post(newPost));
            db.SaveChanges();
            return "Author added";
        });

        app.MapPost("/fake", (PostDto dto) =>
        {
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

        app.MapGet("/news", (string topic, string category) =>
        {
            string newStuff = "Old stuff" + " and new stuff";
            return newStuff;
        });

        app.MapGet("/about/{text}/{number}", ([FromQuery]string text, int number) => $"A site for code – {text} {number}");

        app.MapGet("/", () => "Hello World!");

        app.MapGet("home/privacy", () =>
        {

        });
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