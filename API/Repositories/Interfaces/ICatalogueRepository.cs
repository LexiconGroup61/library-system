namespace API.Repositories.Interfaces;
using Catalogue;

public interface ICatalogueRepository
{
    Directory ReadAll();
}