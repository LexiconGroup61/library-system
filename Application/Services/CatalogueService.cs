using Application.Repositories;
using Application.Data;
using Application.Repositories.Interfaces;
using Application.Services.Interfaces;
using Catalogue;

namespace Application.Services;

public class CatalogueService : ICatalogueService
{
    private readonly LibraryDbContext _context;
    private readonly ICatalogueRepository _repository;

    public CatalogueService(LibraryDbContext context, ICatalogueRepository repo)
    {
        _context = context;
        _repository = repo;
    }

    public void HandleRequest()
    {
        List<Post> posts = _context.Posts.ToList();
        _repository.ReadAll();
    }
    
    public Catalogue.Directory GetSorted()
    {
        throw new NotImplementedException();
    }
}