using Cheetah.Core.Aggregates.CaseAggregate.Links;
using Cheetah.Core.Common;
using Cheetah.Core.Common.DTOs;

namespace Cheetah.Core.Interfaces;
public interface ICopyClass
{
    public SimpleClassDTO GetSimpleClass(BaseEntity simpleClass);
    public Task<L_CaseTaskUser> DeepCopyAsync(L_CaseTaskUser obj);
}