using Ardalis.GuardClauses;
using Cheetah.Application.Business.Condition.Get;

namespace Cheetah.Infrastructure.Persistence.Services;

public class Sync(ApplicationDbContext _db, ISender _ISender) : ISync
{
    public async Task<Result<SimpleClassDTO>> SyncLinkAsync(SimpleClassDTO Base, IEnumerable<SimpleLinkClassDTO> Records, CrudOperation Crud)
    {
        var _ERPCodes = Records.Select(x => Guard.Against.Null(x.ERPCode, $"Id of {x.Name} can not be null"));

        var _IsRead = (Crud is CrudOperation.Read);

        if (Crud == CrudOperation.Create || _IsRead)
        {
            if (Base.Name == nameof(L_UserCondition))
            {
                var _AllUserConditions = await _db.L_UserConditions
                    .Select(item => new SimpleLinkClassDTO()
                    {
                        FirstId = item.FirstId,
                        SecondId = item.SecondId
                    })
                    .ToListAsync();

                var _MostBeAdd = Records.Where(x => !_AllUserConditions
                .Where(y => y.FirstId == x.FirstId)
                .Where(y => y.SecondId == x.SecondId)
                .Any());

                await _db.L_UserConditions.AddRangeAsync(_MostBeAdd.Select(
                    item => new L_UserCondition()
                    {
                        Name = item.Name,
                        DisplayName = item.DisplayName,
                        ERPCode = item.ERPCode,
                        FirstId = item.FirstId,
                        SecondId = item.SecondId
                    }));
            }
        }
        else if (Crud == CrudOperation.Delete || _IsRead)
        {
            if (Base.Name == nameof(L_UserCondition))
            {
                _ = await _db.L_UserConditions
                    .Where(x => Records.Where(y => y.ERPCode == x.ERPCode && !y.EnableRecord).Any())
                    .Where(x => x.EnableRecord)
                    .ExecuteUpdateAsync(setters => setters.SetProperty(field => field.EnableRecord, false));
            }
        }
        await _db.SaveChangesAsync();
        return Base;
    }
    public async Task<Result<SimpleClassDTO>> SyncConditionAsync(SimpleClassDTO Base, IEnumerable<F_Condition> Records, CrudOperation Crud)
    {
        var _ERPCodes = Records.Select(x => Guard.Against.Null(x.ERPCode, $"Id of {x.Name} can not be null"));

        var _IsRead = (Crud is CrudOperation.Read);

        if (Crud == CrudOperation.Create || _IsRead)
        {
            if (Base.Name == nameof(F_Condition))
            {
                var _AllConditionsERPCode = await _db.F_Conditions.Select(x => x.ERPCode).ToListAsync();

                var _MostBeAdd = Records.Where(x => !_AllConditionsERPCode.Any(y => y == x.ERPCode));

                foreach (var _condition in _MostBeAdd)
                {
                    var _getCondition = await _ISender.Send(new CopyConditionQuery(_condition));
                    await _db.F_Conditions.AddAsync(_getCondition);
                }
            }
        }
        if (Crud == CrudOperation.Update || _IsRead)
        {
            if (Base.Name == nameof(F_Condition))
            {
                foreach (var _condition in Records)
                {
                    var _exist = await _db.F_Conditions
                        .Where(x => x.ERPCode == _condition.ERPCode)
                        .SingleOrDefaultAsync();

                    if (_exist is not null)
                    {
                        var _getCondition = await _ISender.Send(new CopyConditionQuery(_condition));

                        _exist.ERPCode = _getCondition.Value.ERPCode;
                        _exist.Name = _getCondition.Value.Name;
                        _exist.Description = _getCondition.Value.Description;
                        _exist.TagId = _getCondition.Value.TagId;
                        _exist.OperandId = _getCondition.Value.OperandId;
                        _exist.Value = _getCondition.Value.Value;
                        _exist.EnableRecord = _getCondition.Value.EnableRecord;

                        _db.F_Conditions.Update(_exist);
                    }
                }
            }
        }
        if (Crud == CrudOperation.Delete || _IsRead)
        {
            _ = await _db.F_Conditions
          .Where(x => Records.Any(y => y.ERPCode == x.ERPCode && !y.EnableRecord))
          .Where(x => !x.EnableRecord)
          .ExecuteUpdateAsync(setters => setters.SetProperty(field => field.EnableRecord, false));
        }

        await _db.SaveChangesAsync();
        return Base;
    }

    #region SyncEntityAsync
    public async Task<Result<SimpleClassDTO>> SyncEntityAsync(SimpleClassDTO Base, IEnumerable<SimpleClassDTO> Records, CrudOperation Crud)
    {
        _ = Records.Select(x => Guard.Against.Null(x.ERPCode, $"Id of {x.Name} can not be null"));

        var _IsRead = (Crud is CrudOperation.Read);

        if (Crud == CrudOperation.Create || _IsRead)
        {
            _ = await SyncEntityCreateAsync(Base, Records);
        }
        if (Crud == CrudOperation.Update || _IsRead)
        {
            _ = await SyncEntityUpdateAsync(Base, Records);
        }
        if (Crud == CrudOperation.Delete || _IsRead)
        {
            _ = await SyncEntityDeleteAsync(Base, Records);
        }
        await _db.SaveChangesAsync();
        return Base;
    }
    public async Task<Result<SimpleClassDTO>> SyncEntityCreateAsync(SimpleClassDTO Base, IEnumerable<SimpleClassDTO> Records)
    {
        if (Base.Name == nameof(D_User))
        {
            var _AllUsersERPCode = await _db.D_Users.Select(x => x.ERPCode).ToListAsync();

            var _MostBeAdd = Records.Where(x => !_AllUsersERPCode.Any(y => y == x.ERPCode));

            if (_MostBeAdd.Any())
            {
                await _db.D_Users.AddRangeAsync(
                    _MostBeAdd.Select(
                    item => new D_User()
                    {
                        Name = item.Name,
                        DisplayName = item.DisplayName,
                        ERPCode = item.ERPCode
                    }));
            }
        }
        else if (Base.Name == nameof(D_Tag))
        {
            var _AllTagsERPCode = await _db.D_Tags.Select(x => x.ERPCode).ToListAsync();

            var _MostBeAdd = Records.Where(x => !_AllTagsERPCode.Any(y => y == x.ERPCode));

            if (_MostBeAdd.Any())
            {
                await _db.D_Tags.AddRangeAsync(_MostBeAdd.Select(
                item => new D_Tag()
                {
                    Name = item.Name,
                    DisplayName = item.DisplayName,
                    ERPCode = item.ERPCode
                }));
            }
        }
        return Base;
    }
    public async Task<Result<SimpleClassDTO>> SyncEntityUpdateAsync(SimpleClassDTO Base, IEnumerable<SimpleClassDTO> Records)
    {
        if (Base.Name == nameof(D_User))
        {
            var _users = await _db.D_Users
                .Where(x => Records.Any(y => y.ERPCode == x.ERPCode))
                .AsNoTracking()
                .ToListAsync();

            if (_users.Any())
            {
                _db.D_Users.UpdateRange(_users);
            }
        }
        else if (Base.Name == nameof(D_Tag))
        {
            var _tags = await _db.D_Tags
                .Where(x => Records.Any(y => y.ERPCode == x.ERPCode))
                .AsNoTracking()
                .ToListAsync();

            if (_tags.Any())
            {
                _db.D_Tags.UpdateRange(_tags);
            }
        }

        return Base;
    }
    public async Task<Result<SimpleClassDTO>> SyncEntityDeleteAsync(SimpleClassDTO Base, IEnumerable<SimpleClassDTO> Records)
    {
        if (Base.Name == nameof(D_User))
        {
            _ = await _db.D_Users
                .Where(x => Records.Any(y => y.ERPCode == x.ERPCode && !y.EnableRecord))
                .ExecuteUpdateAsync(setters => setters.SetProperty(field => field.EnableRecord, false));
        }
        else if (Base.Name == nameof(D_Tag))
        {
            _ = await _db.D_Tags
                  .Where(x => Records.Any(y => y.ERPCode == x.ERPCode))
                  .ExecuteUpdateAsync(setters => setters.SetProperty(field => field.EnableRecord, false));
        }
        return Base;
    }
    #endregion
}
