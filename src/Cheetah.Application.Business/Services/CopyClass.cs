using Cheetah.Application.Business.Interfaces;
using Cheetah.Application.Business.Queries.Case.CaseTaskUser.Get;
using Cheetah.Domain.Aggregates.CaseAggregate.Links;
using Cheetah.Domain.Common;
using Cheetah.Domain.Common.DTOs;

namespace Cheetah.Application.Business.Services;
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