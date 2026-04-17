namespace API.Repositories.Interfaces;
using Catalogue;

public interface ICatalogueRepository
{
    Catalogue ReadAll();
}