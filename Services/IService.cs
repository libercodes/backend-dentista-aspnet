using System.Collections.Generic;
namespace backend.Services
{
    public interface IService<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Create(T obj);
        T DeleteById(int id);
        T Update(T obj);
    }
}