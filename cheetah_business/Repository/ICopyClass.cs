using Cheetah_Business.Data;
using Cheetah_Business.Facts;

namespace Cheetah_Business.Repository
{
    public interface ICopyClass
    {
        public Task<F_Case> DeepCopy(F_Case obj);
        public Task<List<F_Condition>> CopyCondition(IEnumerable<F_Condition> Conditions);
        public Task<Int64?> GetSimpleClassId(IQueryable<SimpleClass> Q_input, SimpleClass input);
        public SimpleClassDTO GetSimpleClass(SimpleClass simpleClass);
    }
}
