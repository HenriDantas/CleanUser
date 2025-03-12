public interface SqlServerAdapter
{
    void connect();
    T update<T>(T entity);
    List<T> list<T>(T entity);
    T first<T>(T entity);
    T insert<T>(T entity);
}