using Cheetah.Domain.Common.DTOs;
using Cheetah.Domain.Entities.Facts;
using Cheetah.Domain.Enums;

namespace Cheetah.Application.Business.Interfaces;
public interface ISync
{
    public Task<Result<SimpleClassDTO>> SyncEntityAsync(SimpleClassDTO Base, IEnumerable<SimpleClassDTO> Records, CrudOperation Crud);
    public Task<Result<SimpleClassDTO>> SyncLinkAsync(SimpleClassDTO Base, IEnumerable<SimpleLinkClassDTO> Records, CrudOperation Crud);
    public Task<Result<SimpleClassDTO>> SyncConditionAsync(SimpleClassDTO Base, IEnumerable<F_Condition> Records, CrudOperation Crud);
}
