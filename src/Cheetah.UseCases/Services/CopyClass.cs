using Cheetah.Core.Aggregates.CaseAggregate.Links;
using Cheetah.Core.Common;
using Cheetah.Core.Common.DTOs;
using Cheetah.Core.Interfaces;
using Cheetah.UseCases.Queries.Case.CaseTaskUser.Get;

namespace Cheetah.UseCases.Services;
public class CopyClass(ISender iSender) : ICopyClass
{
    public SimpleClassDTO GetSimpleClass(BaseEntity simpleClass)
    {
        if (simpleClass is null)
        {
            return new();
        }

        SimpleClassDTO _SimpleClass = new()
        {
            Id = simpleClass.Id,
            SortIndex = simpleClass?.ERPCode,
            ERPCode = simpleClass?.ERPCode,
            Name = simpleClass?.Name,
            DisplayName = simpleClass?.DisplayName
        };


        _SimpleClass.LastModified = simpleClass?.LastModified;

        return _SimpleClass;
    }

    public async Task<L_CaseTaskUser> DeepCopyAsync(L_CaseTaskUser obj)
    {
        var _copyCaseTaskUser = await iSender.Send(new GetCaseTaskUserQuery(obj));

        return _copyCaseTaskUser;
    }
}