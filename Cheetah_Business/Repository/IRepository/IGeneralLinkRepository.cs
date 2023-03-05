namespace Cheetah_Business.Repository.IRepository
{
    using System.Collections.Generic;

    public interface IGeneralLinkRepository<T>
    {
        public Task<IEnumerable<T>> GetAllFirst(long First);
        public Task<IEnumerable<T>> GetAllSecond(long Second);
        public Task<int> delete(long id);
        public Task<T> Get(long? id);
    }
}
