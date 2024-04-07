using Cheetah.Application.Business.Condition.Get;
using Cheetah.Domain.Entities.Facts;
using MediatR;

namespace Cheetah.Infrastructure.Persistence.Services;

public class Sync(ApplicationDbContext _db, ISender _ISender) : ISync
{
    public async Task<Result<SimpleClassDTO>> SyncLinkAsync(SimpleClassDTO Base, IEnumerable<SimpleLinkClassDTO> Records, CrudOperation Crud)
    {
        if (Crud == CrudOperation.Create)
        {
            if (Base.Name == nameof(L_UserCondition))
            {
                await _db.L_UserConditions.AddRangeAsync(Records.Select(
                    item => new L_UserCondition()
                    {
                        Name = item.Name,
                        DisplayName = item.DisplayName,
                        ERPCode = item.ERPCode,
                        FirstId = item.FirstId,
                        SecondId = item.SecondId,
                        ThirdId = item.ThirdId,
                        FourthId = item.FourthId,
                        FifthId = item.FifthId
                    }));
            }
        }
        await _db.SaveChangesAsync();
        return Base;
    }

    public async Task<Result<SimpleClassDTO>> SyncConditionAsync(SimpleClassDTO Base, IEnumerable<F_Condition> Records, CrudOperation Crud)
    {
        if (Crud == CrudOperation.Create)
        {
            if (Base.Name == nameof(F_Condition))
            {
                foreach (var _condition in Records)
                {
                    var _getCondition = await _ISender.Send(new CopyConditionQuery(_condition));
                    await _db.F_Conditions.AddAsync(_getCondition);
                }
            }
        }
        await _db.SaveChangesAsync();
        return Base;
    }

    public async Task<Result<SimpleClassDTO>> SyncEntityAsync(SimpleClassDTO Base, IEnumerable<SimpleClassDTO> Records, CrudOperation Crud)
    {
        if (Crud == CrudOperation.Create)
        {
            if (Base.Name == nameof(D_User))
            {
                await _db.D_Users.AddRangeAsync(Records.Select(
                    item => new D_User()
                    {
                        Name = item.Name,
                        DisplayName = item.DisplayName,
                        ERPCode = item.ERPCode
                    }));
            }
            else if (Base.Name == nameof(D_Tag))
            {
                await _db.D_Tags.AddRangeAsync(Records.Select(
                    item => new D_Tag()
                    {
                        Name = item.Name,
                        DisplayName = item.DisplayName,
                        ERPCode = item.ERPCode
                    }));
            }
        }
        await _db.SaveChangesAsync();
        return Base;
    }
}
