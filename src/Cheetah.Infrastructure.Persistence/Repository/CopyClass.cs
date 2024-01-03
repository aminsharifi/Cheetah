using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Infrastructure.Persistence.Repository;
public class CopyClass(ApplicationDbContext _db, IMapper _mapper, ISync _iSync, ITableCRUD _itableCRUD) : ICopyClass
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
            output = await GetSimpleClassId(_db.D_Users, input);
        }

        return output;
    }

    public async Task<List<F_Condition>> CopyCondition(IEnumerable<F_Condition> Conditions)
    {
        List<F_Condition> list_condition = new List<F_Condition>();

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

            //if (item.User is not null)
            //{
            //    _condition.UserId = await GetSimpleClassId(_db.D_Users, item.User);
            //}
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
        var Return_Case = new F_Case();

        Return_Case.ERPCode = obj?.ERPCode;

        Return_Case.Conditions = await CopyCondition(obj.Conditions);

        Return_Case.CreatorId = await GetSimpleClassId(_db.D_Users, obj.Creator, Return_Case.CreatorId);

        Return_Case.RequestorId = await GetSimpleClassId(_db.D_Users, obj.Requestor, Return_Case.RequestorId);

        Return_Case.ProcessId = await GetSimpleClassId(_db.D_Processes, obj.Process, Return_Case.ProcessId);

        return Return_Case;
    }
}