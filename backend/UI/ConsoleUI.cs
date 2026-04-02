public class Menu
{
    private ChemicalService _service;

    public Menu(ChemicalService service)
    {
        _service = service;
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("1. Add Chemical");
            Console.WriteLine("2. Show All");

            var choice = Console.ReadLine();

            if (choice == "1")
            {
                var chem = new Chemical
                {
                    Id = new Random().Next(1, 1000),
                    Name = "Test",
                    Quantity = 10
                };

                _service.AddChemical(chem);
            }
            else if (choice == "2")
            {
                var list = _service.GetAll();
                foreach (var c in list)
                {
                    Console.WriteLine(c.Name);
                }
            }
        }
    }
}
