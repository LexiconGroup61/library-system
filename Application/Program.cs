using Application;
using Application.Data;
using Application.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(option =>
    option.AddPolicy(name: "lib-front",
        policy =>
        {
            policy.WithOrigins("http://localhost:5173", "http://localhost:5174", "http://localhost:5175")
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials();
        }));
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.RegisterDependencyInjections();
builder.Services.AddDbContext<LibraryDbContext>(options =>
    options.UseSqlite("Data Source=librarydatabase"));
builder.Services.AddIdentityApiEndpoints<LibraryUser>()
    .AddEntityFrameworkStores<LibraryDbContext>();
builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 12;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;
});
builder.Services.ConfigureApplicationCookie(options =>
{
    options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
    options.SlidingExpiration = true;
});

WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles();
app.UseCors("lib-front");

app.UseSession();
app.UseAuthentication();
app.UseAuthorization();
app.MapGroup("/user").MapIdentityApi<LibraryUser>();
app.MapEndpoints();
app.MapControllers();
app.UseCustomMiddleware();
app.Run();

