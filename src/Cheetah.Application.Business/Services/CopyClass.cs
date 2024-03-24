namespace Cheetah.Infrastructure.Persistence.Services;
public class CopyClass(IMediator _mediator) : ICopyClass
{
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

        /*
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
        */
    }

    public async Task<F_WorkItem> DeepCopy(F_WorkItem obj)
    {
        var _copyWorkItem = await _mediator.Send(new CopyWorkItemQuery(obj));

        return _copyWorkItem;

        /*
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
        */
    }

    public async Task<L_CaseTaskUser> DeepCopy(L_CaseTaskUser obj)
    {
        var _copyCaseTaskUser = await _mediator.Send(new CopyCaseTaskUserQuery(obj));

        return _copyCaseTaskUser;

        /*
        L_CaseTaskUser Return_CaseTaskUser = new();

        //Case
        Return_CaseTaskUser.FirstId = await GetSimpleClassId(_db.F_Cases, obj.Case);

        //Task
        Return_CaseTaskUser.SecondId = await GetSimpleClassId(_db.F_Tasks, obj.Task);

        //User
        Return_CaseTaskUser.ThirdId = await GetSimpleClassId(_db.D_Users, obj.User);

        return Return_CaseTaskUser;
        */
    }
}