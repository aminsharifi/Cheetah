namespace Cheetah.Application.Business.Services;

public class Sync(ISender _ISender,
    IRepository<L_UserCondition> userConditionRepository,
    IRepository<F_Condition> conditionRepository,
    IRepository<D_User> userRepository,
    IRepository<D_Tag> tagRepository) : ISync
{
    public async Task<Result<SimpleClassDTO>> SyncLinkAsync(SimpleClassDTO Base, IEnumerable<SimpleLinkClassDTO> Records, CrudOperation Crud)
    {
        _ = Records.Select(x => Guard.Against.Null(x.ERPCode, $"Id of {x.Name} can not be null"));

        var _IsRead = (Crud is CrudOperation.Read);

        if (Crud == CrudOperation.Create || _IsRead)
        {
            if (Base.Name == nameof(L_UserCondition))
            {
                GetEntityLinkSpec<L_UserCondition> _getEntityLinkSpec = new();

                var _AllUserConditions = await userConditionRepository.ListAsync(_getEntityLinkSpec);

                var _MostBeAdd = Records.Where(x => !_AllUserConditions
                .Where(y => y.FirstId == x.FirstId)
                .Where(y => y.SecondId == x.SecondId)
                .Any());

                _ = await userConditionRepository.AddRangeAsync(_MostBeAdd.Select(
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
        if (Crud == CrudOperation.Delete || _IsRead)
        {
            var _FilterdRecords = Records.Where(y => !y.EnableRecord).Select(y => y.ERPCode);

            if (Base.Name == nameof(L_UserCondition))
            {
                GetEntitiesByERPCodeSpec<L_UserCondition> _getEntityLinkByERPCodeSpec = new(_FilterdRecords);

                var _AllUserConditions = await userConditionRepository.ListAsync(_getEntityLinkByERPCodeSpec);

                Parallel.ForEach(_AllUserConditions, _AllUserCondition =>
                {
                    _AllUserCondition.EnableRecord = false;
                });

                await userConditionRepository.UpdateRangeAsync(_AllUserConditions);
            }
        }

        return Base;
    }
    public async Task<Result<SimpleClassDTO>> SyncConditionAsync(SimpleClassDTO Base, IEnumerable<F_Condition> Records, CrudOperation Crud)
    {
        _ = Records.Select(x => Guard.Against.Null(x.ERPCode, $"Id of {x.Name} can not be null"));

        var _IsRead = (Crud is CrudOperation.Read);

        GetAllERPCodesSpec<F_Condition> _getAllConditionsSpec = new();

        var _AllConditionsERPCode = await conditionRepository.ListAsync(_getAllConditionsSpec);

        if (Crud == CrudOperation.Create || _IsRead)
        {
            if (Base.Name == nameof(F_Condition))
            {
                var _MostBeAdd = Records.Where(x => !_AllConditionsERPCode.Contains(x.ERPCode));

                List<F_Condition> _Conditions = new();

                await Parallel.ForEachAsync(_MostBeAdd, async (_condition, CancellationToken) =>
                {
                    var _getCondition = await _ISender.Send(new CopyConditionQuery(_condition));

                    _Conditions.Add(_getCondition);
                });

                _ = await conditionRepository.AddRangeAsync(_Conditions);
            }
        }
        if (Crud == CrudOperation.Update || Crud == CrudOperation.Delete || _IsRead)
        {
            if (Base.Name == nameof(F_Condition))
            {

                _ = Records.Select(x => Guard.Against.Null(x.ERPCode, "ERPCode can not be null"));

                var _ExtractERPCodes = Records.Select(x => x.ERPCode);

                GetEntitiesByERPCodeSpec<F_Condition> _GetConditionSpec = new(ERPCodes: _ExtractERPCodes);

                var _FilterdRecords = await conditionRepository.ListAsync(_GetConditionSpec);

                List<F_Condition> _Conditions = new();
                Parallel.ForEach(_FilterdRecords, _FilterdRecord =>
                {
                    var Record = Records.Where(x => x.ERPCode == _FilterdRecord.ERPCode).Single();
                    _FilterdRecord.Name = Record.Name;
                    _FilterdRecord.DisplayName = Record.Name;
                    _FilterdRecord.Description = Record.Description;
                    _FilterdRecord.EnableRecord = Record.EnableRecord;
                    _Conditions.Add(_FilterdRecord);
                });

                await conditionRepository.UpdateRangeAsync(_Conditions);
            }
        }
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
        if (Crud == CrudOperation.Update || Crud == CrudOperation.Delete || _IsRead)
        {
            _ = await SyncEntityUpdateAsync(Base, Records);
        }
        return Base;
    }
    public async Task<Result<SimpleClassDTO>> SyncEntityCreateAsync(SimpleClassDTO Base, IEnumerable<SimpleClassDTO> Records)
    {
        if (Base.Name == nameof(D_User))
        {
            GetAllERPCodesSpec<D_User> _getAllConditionsSpec = new();
            var _AllUsersERPCode = await userRepository.ListAsync(_getAllConditionsSpec);
            var _MostBeAdd = Records.Where(x => !_AllUsersERPCode.Any(y => y == x.ERPCode));
            var _UsersList = _MostBeAdd.Select(
                    item => new D_User()
                    {
                        Name = item.Name,
                        DisplayName = item.DisplayName,
                        Description = item.Description,
                        ERPCode = item.ERPCode,
                        EnableRecord = item.EnableRecord
                    });
            _ = await userRepository.AddRangeAsync(_UsersList);
        }
        else if (Base.Name == nameof(D_Tag))
        {
            GetAllERPCodesSpec<D_Tag> _getAllConditionsSpec = new();
            var _AllTagsERPCode = await tagRepository.ListAsync(_getAllConditionsSpec);
            var _MostBeAdd = Records.Where(x => !_AllTagsERPCode.Any(y => y == x.ERPCode));
            var _UsersList = _MostBeAdd.Select(
                    item => new D_Tag()
                    {
                        Name = item.Name,
                        DisplayName = item.DisplayName,
                        Description = item.Description,
                        ERPCode = item.ERPCode,
                        EnableRecord = item.EnableRecord
                    });
            _ = await tagRepository.AddRangeAsync(_UsersList);
        }

        return Base;
    }
    public async Task<Result<SimpleClassDTO>> SyncEntityUpdateAsync(SimpleClassDTO Base, IEnumerable<SimpleClassDTO> Records)
    {
        if (Base.Name == nameof(D_User))
        {
            GetEntitiesByERPCodeSpec<D_User> _GetEntitiesByERPCodeSpec = new(ERPCodes: Records.Select(y => y.ERPCode));
            var _FilterdRecords = await userRepository.ListAsync(_GetEntitiesByERPCodeSpec);

            List<D_User> _Users = new();
            Parallel.ForEach(_FilterdRecords, _FilterdRecord =>
            {
                var Record = Records.Where(x => x.ERPCode == _FilterdRecord.ERPCode).Single();
                _FilterdRecord.Name = Record.Name;
                _FilterdRecord.DisplayName = Record.DisplayName;
                _FilterdRecord.Description = Record.Description;
                _FilterdRecord.EnableRecord = Record.EnableRecord;
                _Users.Add(_FilterdRecord);
            });

            await userRepository.UpdateRangeAsync(_Users);
        }
        else if (Base.Name == nameof(D_Tag))
        {
            GetEntitiesByERPCodeSpec<D_Tag> _GetEntitiesByERPCodeSpec = new(ERPCodes: Records.Select(y => y.ERPCode));
            var _FilterdRecords = await tagRepository.ListAsync(_GetEntitiesByERPCodeSpec);

            List<D_Tag> _Users = new();

            Parallel.ForEach(_FilterdRecords, _FilterdRecord =>
            {
                var Record = Records.Where(x => x.ERPCode == _FilterdRecord.ERPCode).Single();
                _FilterdRecord.Name = Record.Name;
                _FilterdRecord.DisplayName = Record.Name;
                _FilterdRecord.Description = Record.Description;
                _FilterdRecord.EnableRecord = Record.EnableRecord;
                _Users.Add(_FilterdRecord);
            });

            await tagRepository.UpdateRangeAsync(_Users);
        }

        return Base;
    }

    #endregion
}
