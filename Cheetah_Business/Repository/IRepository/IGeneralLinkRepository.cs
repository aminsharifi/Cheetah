namespace Cheetah_Business.Repository.IRepository
{
    using System.Collections.Generic;

    public interface IGeneralLinkRepository<T> : IGeneralRepository<T>
    {
        public Task<IEnumerable<T>> GetAllFirst(long First);
        public Task<IEnumerable<T>> GetAllSecond(long Second);
    }
}
