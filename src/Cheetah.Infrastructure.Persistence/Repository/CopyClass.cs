using Microsoft.VisualBasic;
using System.Collections.ObjectModel;

namespace Cheetah.Infrastructure.Persistence.Repository;
public class CopyClass(ApplicationDbContext _db, IMapper _mapper, ITableCRUD _itableCRUD) : ICopyClass
{
    public async Task<Int64?> GetSimpleClassId(IQueryable<BaseEntity> Q_input, BaseEntity input)
    {
        var Find = false;

        if (input.Id is not null and > 0)
        {
            Find = true;
            return input.Id.Value;
        }
        Q_input = Q_input.AsNoTracking();

        if (!String.IsNullOrEmpty(input.Name))
        {
            Find = true;
            Q_input = Q_input.Where(x => x.Name == input.Name);
        }

        if (input.ERPCode is not null and > 0)
        {
            Find = true;
            Q_input = Q_input.Where(x => x.ERPCode == input.ERPCode);
        }

        if (!Find)
        {
            return null;
        }


        return await Q_input.Select(x => x.Id.Value).SingleAsync();
    }

    public async Task<Int64?> GetSimpleClassId(IQueryable<BaseEntity> Q_input, BaseEntity input, Int64? output)
    {
        if (output is null or 0)
        {
            output = await GetSimpleClassId(Q_input, input);
        }

        return output;
    }

    public async Task<ICollection<F_Condition>> CopyCondition(IEnumerable<F_Condition> Conditions)
    {
        Collection<F_Condition> list_condition = new();

        foreach (var item in Conditions)
        {
            var _condition = new F_Condition();

            _condition.Id = item?.Id;
            _condition.ERPCode = item?.ERPCode;
            _condition.Name = item?.Name;
            _condition.Value = item?.Value;

            if (item.Tag is not null)
            {
                _condition.TagId = await GetSimpleClassId(_db.D_Tags, item.Tag);
            }
            if (item.Operand is not null)
            {
                _condition.OperandId = await GetSimpleClassId(_db.D_Operands, item.Operand);
            }

            var _find_Condition = _db.F_Conditions.Where(x => x.TagId == _condition.TagId)
                .Where(x => x.OperandId == _condition.OperandId)
                .Where(x => x.Value == _condition.Value);

            if (await _find_Condition.AnyAsync())
            {
                _condition = await _find_Condition.SingleAsync();
            }

            list_condition.Add(_condition);
        }

        return list_condition;
    }

    public SimpleClassDTO GetSimpleClass(BaseEntity simpleClass)
    {
        SimpleClassDTO _SimpleClass = new();

        if (simpleClass is null)
        {
            return _SimpleClass;
        }

        _SimpleClass.Id = simpleClass?.Id;

        _SimpleClass.ERPCode = simpleClass?.ERPCode;

        _SimpleClass.Name = simpleClass?.Name;

        _SimpleClass.DisplayName = simpleClass?.DisplayName;

        _SimpleClass.Created = simpleClass?.Created;

        _SimpleClass.LastModified = simpleClass?.LastModified;

        return _SimpleClass;
    }

    public async Task<F_Case> DeepCopy(F_Case obj)
    {
        F_Case Return_Case = new();

        Return_Case.ERPCode = obj?.ERPCode;
        Return_Case.CreatorId = await GetSimpleClassId(_db.D_Users, obj.Creator, Return_Case.CreatorId);
        Return_Case.RequestorId = await GetSimpleClassId(_db.D_Users, obj.Requestor, Return_Case.RequestorId);
        Return_Case.ProcessId = await GetSimpleClassId(_db.D_Processes, obj.Process, Return_Case.ProcessId);

        var _conditions = await CopyCondition(obj.CaseConditions.Select(x => x.Condition));

        foreach (var _condition in _conditions)
        {
            Return_Case.CaseConditions.Add(new()
            {
                Case = Return_Case,
                FirstId = Return_Case.Id,
                Condition = _condition,
                SecondId = _condition.Id
            });
        }

        return Return_Case;
    }
    public async Task<L_CaseTaskUser> DeepCopy(L_CaseTaskUser obj)
    {
        L_CaseTaskUser Return_CaseTaskUser = new();

        //Case
        Return_CaseTaskUser.FirstId = await GetSimpleClassId(_db.F_Cases, obj.Case);

        //Task
        Return_CaseTaskUser.SecondId = await GetSimpleClassId(_db.F_Tasks, obj.Task);

        //User
        Return_CaseTaskUser.ThirdId = await GetSimpleClassId(_db.D_Users, obj.User);

        return Return_CaseTaskUser;
    }
}