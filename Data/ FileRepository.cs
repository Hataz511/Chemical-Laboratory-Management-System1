using System.Text;

public class FileRepository<T> : IRepository<T> where T : class
{
    private readonly string _filePath;
    private List<T> _items;

    public FileRepository(string filePath)
    {
        _filePath = filePath;
        _items = new List<T>();

        if (File.Exists(_filePath))
        {
            var lines = File.ReadAllLines(_filePath);
            foreach (var line in lines)
            {
                // Deserialize manually or with JSON
                _items.Add(System.Text.Json.JsonSerializer.Deserialize<T>(line)!);
            }
        }
    }

    public List<T> GetAll() => _items;

    public T? GetById(Guid id)
        => _items.FirstOrDefault();

    public void Add(T entity)
        => _items.Add(entity);

    public void Save()
    {
        var lines = _items.Select(i =>
            System.Text.Json.JsonSerializer.Serialize(i));

        File.WriteAllLines(_filePath, lines);
    }
}