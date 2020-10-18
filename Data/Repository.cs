using System.Collections.Generic;
using backend.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly Context _context;
        private DbSet<T> entities;
        public Repository(Context context)
        {
            _context = context;
            entities = context.Set<T>();
        }
        public void Create(T obj)
        {
            entities.Add(obj);
        }

        public T DeleteById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable<T>();
        }

        public T GetById(int id)
        {
            return entities.FirstOrDefault(p => p.Id == id);
        }

        public T Update(T obj)
        {
            throw new System.NotImplementedException();
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}