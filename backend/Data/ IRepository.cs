public interface IRepository<T>
{
    List<T> GetAll();
    T? GetById(Guid id);
    void Add(T entity);
    void Save();
}