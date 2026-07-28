using Application.Repositories;
using Application.Repositories.Interfaces;
using Application.Services.Interfaces;

namespace Application;

public static class WebApplicationBuilderExtensions
{
    public static void RegisterDependencyInjections(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<ICatalogueRepository, CatalogueRepository>();
        builder.Services.AddScoped<ICatalogueService, Application.Services.CatalogueService>();

    }
}