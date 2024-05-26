namespace Cheetah.Application.Business.Services;
public class CopyClass(ISender iSender) : ICopyClass
{
    public SimpleClassDTO GetSimpleClass(BaseEntity simpleClass)
    {
        if (simpleClass is null)
        {
            return new();
        }

        SimpleClassDTO _SimpleClass = new(id: simpleClass.Id, sortIndex: simpleClass?.ERPCode,
            eRPCode: simpleClass?.ERPCode,
            name: simpleClass?.Name, displayName: simpleClass?.DisplayName);


        _SimpleClass.UpdateLastModified(simpleClass?.LastModified);

        return _SimpleClass;
    }

    public async Task<L_CaseTaskUser> DeepCopyAsync(L_CaseTaskUser obj)
    {
        var _copyCaseTaskUser = await iSender.Send(new CopyCaseTaskUserQuery(obj));

        return _copyCaseTaskUser;
    }
}