using System.Collections.Generic;
using backend.Data;
namespace backend.Services
{
    public class Service<T> : IService<T> where T : Models.BaseEntity
    {
        public readonly IRepository<T> _repository;

        public Service(IRepository<T> repo)
        {
            _repository = repo;
        }
        public void Create(T obj)
        {
            _repository.Create(obj);
            _repository.SaveChanges();
        }

        public T DeleteById(int id)
        {
            return _repository.DeleteById(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public T Update(T obj)
        {
            return _repository.Update(obj);
        }
    }
}