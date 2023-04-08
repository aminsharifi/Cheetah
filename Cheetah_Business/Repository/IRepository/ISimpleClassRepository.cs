namespace Cheetah_Business.Repository.IRepository
{
    using Cheetah_DataAccess.Data;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;

    public interface ISimpleClassRepository
    {
        public Task<int> delete(string type, long id);
        public Task<IEnumerable<SimpleClass>> GetAllByName(String type);
        public Task<IEnumerable<KeyValuePair<String, String>>> GetAllTableName(String SchemaName);
        public Task<IEnumerable<SimpleLinkClass>> GetAllLink(String type, String sd_Status, long linkID);
        public Task<SimpleClass> Get(string type, long? id, QueryTrackingBehavior Tracking = QueryTrackingBehavior.TrackAll);
        public Task<SimpleClass> Create(SimpleClass obj_DTO);
        public Task<SimpleClass> Update(SimpleClass obj_DTO);

    }
}