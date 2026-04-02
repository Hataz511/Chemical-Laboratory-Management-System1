public class ConsoleUI
{
    private readonly ChemicalService _service;

    public ConsoleUI(ChemicalService service)
    {
        _service = service;
    }

    public void Start()
    {
        Console.WriteLine("1. Add Chemical");
        var choice = Console.ReadLine();

        if (choice == "1")
        {
            var chem = new Chemical
            {
                Name = "Test",
                Quantity = 10
            };

            _service.AddChemical(chem);
        }
    }
}
