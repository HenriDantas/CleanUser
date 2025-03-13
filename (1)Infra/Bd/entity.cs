public class Entity
{
    // privare readonly ;
    public T update<T>(T entity) {
        return entity;
    }

    public List<T> list<T>(T entity) {
        return new List<T>();
    }

    public T first<T>(T entity) {
        return entity;
    }

    public T insert<T>(T entity) {
        return entity;
    }
}