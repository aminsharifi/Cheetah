namespace Cheetah.Application.Business.Interfaces;
public interface ICopyClass
{
    public SimpleClassDTO GetSimpleClass(BaseEntity simpleClass);
    public Task<F_Case> DeepCopy(F_Case obj);
    public Task<F_WorkItem> DeepCopy(F_WorkItem obj);
    public Task<L_CaseTaskUser> DeepCopy(L_CaseTaskUser obj);
}