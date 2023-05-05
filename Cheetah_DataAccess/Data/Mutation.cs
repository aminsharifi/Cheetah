using Cheetah_Business.Data;
using Cheetah_Business.Repository;
using HotChocolate;

namespace Cheetah_DataAccess.Data
{
    public class Mutation
    {
        public async Task<SimpleClass> AddTableAsync(
            [Service] ISimpleClassRepository iSimpleClassRepository,
            String TableName, String PName, String PDisplayName)
        {
            var d_Entity = await iSimpleClassRepository.Get(TableName, 0);
            d_Entity.PName = PName;
            d_Entity.PDisplayName = PDisplayName;

            return await iSimpleClassRepository.Create(d_Entity);
        }
    }
}
