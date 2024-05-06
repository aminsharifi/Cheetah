namespace Cheetah.Application.Business.Services;
public class CopyClass(ISender iSender) : ICopyClass
{
    public SimpleClassDTO GetSimpleClass(BaseEntity simpleClass)
    {
        SimpleClassDTO _SimpleClass = new();

        if (simpleClass is null)
        {
            return _SimpleClass;
        }

        _SimpleClass.Id = simpleClass.Id;

        _SimpleClass.ERPCode = simpleClass?.ERPCode;

        _SimpleClass.Name = simpleClass?.Name;

        _SimpleClass.DisplayName = simpleClass?.DisplayName;

        _SimpleClass.Created = simpleClass?.Created;

        _SimpleClass.LastModified = simpleClass?.LastModified;

        return _SimpleClass;
    }

    public async Task<L_CaseTaskUser> DeepCopyAsync(L_CaseTaskUser obj)
    {
        var _copyCaseTaskUser = await iSender.Send(new CopyCaseTaskUserQuery(obj));

        return _copyCaseTaskUser;
    }
}