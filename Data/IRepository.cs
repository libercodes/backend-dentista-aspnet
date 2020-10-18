using System.Collections.Generic;
using backend.Models;

namespace backend.Data
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Create(T obj);
        T DeleteById(int id);
        T Update(T obj);
        void SaveChanges();
    }
}