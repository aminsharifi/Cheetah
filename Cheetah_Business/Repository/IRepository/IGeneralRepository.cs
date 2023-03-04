namespace Cheetah_Business.Repository.IRepository
{
    using System.Collections.Generic;

    public interface IGeneralRepository<T>
    {
        public Task<T> Create(T obj_DTO);
        public Task<T> Update(T obj_DTO);
        public Task<int> delete(long id);
        public Task<T> Get(long? id);
        public Task<IEnumerable<T>> GetAll();
        public Task<IEnumerable<Object>> GetAllByName(String Name);
    }
}
