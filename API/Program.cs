using API.Data;
using Catalogue;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<LibraryDbContext>(options =>
    options.UseSqlite("Data Source=librarydatabase"));
WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseAuthentication();
app.UseAuthorization();

app.MapPost("/post", (Post newPost, LibraryDbContext db) =>
{
    db.Posts.Add(newPost);
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

app.MapGet("/news", () =>
{
    string newStuff = "Old stuff" + " and new stuff";
    return newStuff;
});

app.MapGet("/about/{text}/{number}", (string text, int number) => $"A site for code – {text} {number}");

app.MapGet("/", () => "Hello World!");

app.Run();