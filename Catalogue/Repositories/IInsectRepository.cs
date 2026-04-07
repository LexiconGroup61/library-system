namespace Catalogue.Repositories;

public interface IInsectRepository
{
    // CRUD Create Read Update Delete
    List<Insect> ReadAll();
    Insect Read(int id);
    Insect Create(Insect insect);
    Insect Update(Insect insect);
    bool Delete(Insect insect);
}