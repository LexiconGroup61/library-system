using Catalogue.Repositories;

namespace Catalogue.Services;

public class InsectService
{
    private readonly IInsectRepository _repo;

    public InsectService(IInsectRepository repo)
    {
        _repo = repo;
    }
}