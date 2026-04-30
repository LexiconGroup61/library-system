using Application;
using Application.Data;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.RegisterDependencyInjections();
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
app.MapEndpoints();
app.MapControllers();
app.UseCustomMiddleware();
app.Run();

