namespace Cheetah.Application.Business.Repository;
public interface ICopyClass
{
    public Task<F_Case> DeepCopy(F_Case obj);
    public Task<List<F_Condition>> CopyCondition(IEnumerable<F_Condition> Conditions);
    public Task<Int64?> GetSimpleClassId(IQueryable<BaseEntity> Q_input, BaseEntity input);
    public SimpleClassDTO GetSimpleClass(BaseEntity simpleClass);
    public Task<L_CaseTaskUser> DeepCopy(L_CaseTaskUser obj);
}