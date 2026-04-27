using API.Data;
using API.Repositories;
using API.Repositories.Interfaces;
using API.Services.Interfaces;
using Catalogue;

namespace API.Services;

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