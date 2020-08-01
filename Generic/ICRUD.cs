namespace Generic
{
    public interface ICRUD<T>
    {
        int Create(T item);
        T Read(int id);
        void Update(int id);
        void Delete(int id);
    }
}