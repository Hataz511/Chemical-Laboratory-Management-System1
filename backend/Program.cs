class Program
{
    static void Main(string[] args)
    {
        var repo = new FileRepository<Chemical>("chemicals.csv");
        var service = new ChemicalService(repo);
        var ui = new Menu(service);

        ui.Start();
    }
}
