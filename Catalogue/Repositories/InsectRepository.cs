namespace Catalogue.Repositories;

public class InsectRepository : IInsectRepository
{
    public List<Insect> Insects { get; private set; } = new List<Insect>();
    
    public List<Insect> ReadAll()
    {
        return Insects;
    }

    public Insect Read(int id)
    {
        return Insects.Find(i => i.Id == id);
    }

    public Insect Create(Insect insect)
    {
        Insects.Add(insect);
        return insect;
    }

    public Insect Update(Insect insect)
    {
        int index = Insects.FindIndex(i => i.Id == insect.Id);
        Insects[index] = insect;
        return insect;
    }

    public bool Delete(Insect insect)
    {
        return Insects.Remove(insect);
    }
}