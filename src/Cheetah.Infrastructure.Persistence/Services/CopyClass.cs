using Cheetah.Application.Business.Case.Get;
using Cheetah.Application.Business.CaseTaskUser.Get;
using Cheetah.Application.Business.WorkItem.Get;

namespace Cheetah.Infrastructure.Persistence.Services;
public class CopyClass(ApplicationDbContext _db, ITableCRUD _itableCRUD, IMediator _mediator) : ICopyClass
{
    public async Task<Int64?> GetSimpleClassId(IQueryable<BaseEntity> Q_input, BaseEntity input)
    {
        var Find = false;

        if (input.Id > 0)
        {
            Find = true;
            return input.Id;
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


        return await Q_input.Select(x => x.Id).SingleAsync();
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
            F_Condition _condition = new();

            _condition.Id = item.Id;
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

        _SimpleClass.Id = simpleClass.Id;

        _SimpleClass.ERPCode = simpleClass?.ERPCode;

        _SimpleClass.Name = simpleClass?.Name;

        _SimpleClass.DisplayName = simpleClass?.DisplayName;

        _SimpleClass.Created = simpleClass?.Created;

        _SimpleClass.LastModified = simpleClass?.LastModified;

        return _SimpleClass;
    }

    public async Task<F_Case> DeepCopy(F_Case obj)
    {
        var _copyCaseQuery = await _mediator.Send(new CopyCaseQuery(obj));

        return _copyCaseQuery;

        F_Case _case = new();

        _case.ERPCode = obj?.ERPCode;
        _case.CreatorId = await GetSimpleClassId(_db.D_Users, obj.Creator, _case.CreatorId);
        _case.RequestorId = await GetSimpleClassId(_db.D_Users, obj.Requestor, _case.RequestorId);
        _case.ProcessId = await GetSimpleClassId(_db.D_Processes, obj.Process, _case.ProcessId);

        var _conditions = await CopyCondition(obj.CaseConditions.Select(x => x.Condition));

        foreach (var _condition in _conditions)
        {
            _case.CaseConditions.Add(new()
            {
                SecondId = _condition.Id
            });
        }

        var _workItems = obj.WorkItems;

        foreach (var _workItem in _workItems)
        {
            var _CopiedworkItem = await DeepCopy(_workItem);
            _case.WorkItems.Add(_CopiedworkItem);
        }

        return _case;
    }

    public async Task<F_WorkItem> DeepCopy(F_WorkItem obj)
    {
        var _copyWorkItem = await _mediator.Send(new CopyWorkItemQuery(obj));

        return _copyWorkItem;

        F_WorkItem _workItem = new();

        if (obj.Id != 0)
        {
            _workItem = await _db.F_WorkItems
               .Where(x => x.Id == obj.Id)
               .Include(x => x.Case)
               .ThenInclude(x => x.WorkItems)
               .ThenInclude(x => x.Task)
               .Include(x => x.Case)
               .ThenInclude(x => x.CaseConditions)
               .ThenInclude(x => x.Condition)
               .FirstAsync();
        }

        _workItem.UserId = await GetSimpleClassId(_db.D_Users, obj.User, _workItem.UserId);

        var _conditions = await CopyCondition(obj.WorkItemConditions.Select(x => x.Condition));

        foreach (var _condition in _conditions)
        {
            _workItem.WorkItemConditions.Add(new()
            {
                SecondId = _condition.Id
            });
        }

        return _workItem;
    }

    public async Task<L_CaseTaskUser> DeepCopy(L_CaseTaskUser obj)
    {
        var _copyCaseTaskUser = await _mediator.Send(new CopyCaseTaskUserQuery(obj));

        return _copyCaseTaskUser;

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