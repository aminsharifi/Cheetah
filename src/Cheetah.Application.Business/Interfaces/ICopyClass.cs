namespace Cheetah.Application.Business.Interfaces;
public interface ICopyClass
{
    public SimpleClassDTO GetSimpleClass(BaseEntity simpleClass);    
    public Task<L_CaseTaskUser> DeepCopyAsync(L_CaseTaskUser obj);
}