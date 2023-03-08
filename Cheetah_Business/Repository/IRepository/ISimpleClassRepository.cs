namespace Cheetah_Business.Repository.IRepository
{
    using Cheetah_DataAccess.Data;
    using System.Collections.Generic;

    public interface ISimpleClassRepository
    { 
        public Task<int> delete(string type,long id);
        public Task<IEnumerable<SimpleClass>> GetAllByName(String type);
    }
}