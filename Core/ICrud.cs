namespace Core
{
    public interface ICrud<T>
    {
        int Create(T item);
        T Read(int id);
        void Update(T item);
        void Delete(int id);
    }
}