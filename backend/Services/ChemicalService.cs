public class ChemicalService
{
    private readonly IRepository<Chemical> _repo;

    public ChemicalService(IRepository<Chemical> repo)
    {
        _repo = repo;
    }

    public void AddChemical(Chemical chem)
    {
        _repo.Add(chem);
        _repo.Save();
    }

    public List<Chemical> GetAll()
    {
        return _repo.GetAll();
    }
}
