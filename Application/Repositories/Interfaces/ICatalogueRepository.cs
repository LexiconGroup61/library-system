namespace Application.Repositories.Interfaces;
using Catalogue;

public interface ICatalogueRepository
{
    Directory ReadAll();
}