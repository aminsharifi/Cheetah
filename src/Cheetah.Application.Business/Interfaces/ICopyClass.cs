namespace Cheetah.Application.Business.Interfaces;
public interface ICopyClass
{
    public SimpleClassDTO GetSimpleClass(BaseEntity simpleClass);
    public Task<F_Case> DeepCopyAsync(F_Case obj);
    public Task<F_WorkItem> DeepCopyAsync(F_WorkItem obj);
    public Task<L_CaseTaskUser> DeepCopyAsync(L_CaseTaskUser obj);
}