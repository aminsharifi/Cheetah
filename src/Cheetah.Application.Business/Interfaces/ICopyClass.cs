namespace Cheetah.Application.Business.Interfaces;
public interface ICopyClass
{
    public SimpleClassDTO GetSimpleClass(BaseEntity simpleClass);
    public Task<F_WorkItem> DeepCopyAsync(F_WorkItem obj, D_User User);
    public Task<L_CaseTaskUser> DeepCopyAsync(L_CaseTaskUser obj);
}