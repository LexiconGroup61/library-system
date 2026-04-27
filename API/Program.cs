using API.Data;
using API.Repositories;
using API.Repositories.Interfaces;
using API.Services.Interfaces;
using Catalogue;
using Catalogue.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();


builder.Services.AddScoped<ICatalogueRepository, CatalogueRepository>();
builder.Services.AddScoped<ICatalogueService, API.Services.CatalogueService>();

builder.Services.AddDbContext<LibraryDbContext>(options =>
    options.UseSqlite("Data Source=librarydatabase"));
WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();

app.UseAuthentication();
app.UseAuthorization();

app.MapGet("/post", ([FromBody]PostDto newPost, LibraryDbContext db) =>
{
    db.Posts.Add(new Post(newPost));
    db.SaveChanges();
    return "Author added";
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

app.MapControllers();

app.Run();

