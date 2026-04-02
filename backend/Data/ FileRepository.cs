using System.IO;

public class FileRepository<T> : IRepository<T> where T : class
{
    private List<T> _data;
    private string _filePath;

    public FileRepository(string filePath)
    {
        _filePath = filePath;
        _data = new List<T>();
    }

    public List<T> GetAll()
    {
        return _data;
    }

    public T GetById(int id)
    {
        return _data.FirstOrDefault();
    }

    public void Add(T entity)
    {
        _data.Add(entity);
    }

    public void Save()
    {
        File.WriteAllText(_filePath, "Saved (simulim)");
    }
}
}
