using System.Collections.Generic;

namespace Generic
{
    public interface ICRUD<T>
    {
        int Create(T item);
        T Read(int id);
        List<T> Read();
        void Update(int id);
        void Delete(int id);
    }
}