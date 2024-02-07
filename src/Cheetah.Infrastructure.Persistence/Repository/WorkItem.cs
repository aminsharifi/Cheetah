namespace Cheetah.Infrastructure.Persistence.Repository;
public class WorkItem(ApplicationDbContext _db, IMapper _mapper, ITableCRUD _itableCRUD, ICopyClass _iCopyClass) : IWorkItem
{
    public CheetahResult<IQueryable<F_Task>> GetAllTask()
    {
        #region Tasks
        var eP_Tasks_Query =
            _db.F_Tasks
            .Where(x => x.EnableRecord == true)
            .AsNoTracking()
            .OrderBy(x => x.SortIndex);


        #region Variables
        var eP_Tasks_Query2 = eP_Tasks_Query
            .Include(x => x.Condition)
            .ThenInclude(x => x.Tag)
            .Include(x => x.Condition)
            .ThenInclude(x => x.Operand);

        #endregion

        #region TaskItem

        var eP_Tasks_Query3 = eP_Tasks_Query2
            .Include(x => x.TaskAction)
            .ThenInclude(x => x.Action)
            .ThenInclude(x => x.CaseState);

        #region Conditions
        var eP_Tasks_Query4 = eP_Tasks_Query3
            .Include(x => x.TaskAction)
            .ThenInclude(x => x.Action)
            .ThenInclude(x => x.Conditions)
            .ThenInclude(x => x.Tag)
            .Include(x => x.TaskAction)
            .ThenInclude(x => x.Action)
            .ThenInclude(x => x.Conditions)
            .ThenInclude(x => x.Operand);
        #endregion

        #region TaskItem
        var eP_Tasks_Query5 = eP_Tasks_Query4
            .Include(x => x.TaskAction)
            .ThenInclude(x => x.Task);

        #endregion

        #endregion

        #endregion

        var Tasks = OutputState<IQueryable<F_Task>>.Success("خروجی", eP_Tasks_Query4.AsQueryable<F_Task>());

        return Tasks;

    }
    public async Task<CheetahResult<bool>> SetWorkItemsAsync(F_Case Current_Case, F_WorkItem? Current_WorkItem = null)
    {
        try
        {
            var pc_ProcessScenario = await _db.L_ProcessScenarios
                .Where(x => x.FirstId == Current_Case.ProcessId)
                .Where(x => x.EnableRecord == true)
                .Include(x => x.Scenario)
                .ThenInclude(x => x.Conditions)
                .AsNoTracking()
                .ToListAsync();

            var Actual_Conditions = Current_Case.Conditions;

            foreach (var ProcessScenario in pc_ProcessScenario)
            {
                var ConditionOccures = false;

                var Expected_Conditions = ProcessScenario.Scenario.Conditions
                .Where(x => x.Value is not null);

                ConditionOccures = CompareCondition(Actual_Conditions, Expected_Conditions).Result.Value;

                if (ConditionOccures)
                {
                    Current_Case.SelectedScenarioId = ProcessScenario.Scenario.Id;
                    break;
                }
            }

            var eP_Tasks = await GetAllTask().Result.Value
                 .Where(x => x.ScenarioId == Current_Case.SelectedScenarioId.Value)
                 .ToListAsync();

            F_WorkItem first_WorkItem = new()
            {
                Case = Current_Case
            };

            foreach (var eP_Task in eP_Tasks)
            {
                //if (eP_Task.Role.FixedRole)
                if (false)
                {
                    F_WorkItem f_WorkItem = new()
                    {
                        Case = Current_Case,
                        TaskId = eP_Task.Id
                    };

                    //if (eP_Task.IsRequestor())
                    //{
                    //    f_WorkItem.UserId = Current_Case.RequestorId;
                    //}
                    //else if (eP_Task.IsRequestorManager())
                    //{
                    //    f_WorkItem.UserId = Current_Case.Requestor.Parent_Id;
                    //}
                    if (first_WorkItem.TaskId is null)
                    {
                        first_WorkItem = f_WorkItem;
                    }

                    Current_Case.WorkItems.Add(f_WorkItem);
                }
                else
                {
                    //var Positions = await _db.L_RolePositions
                    //    .Where(x => x.FirstId == eP_Task.RoleId)
                    //    .Where(x => x.EnableRecord == true)
                    //    .AsNoTracking()
                    //    .Select(x => x.SecondId)
                    //    .ToListAsync();

                    //var Users = await _db.L_UserPositions
                    //    .Where(x => Positions.Contains(x.SecondId))
                    //    .Where(x => x.EnableRecord == true)
                    //    .AsNoTracking()
                    //    .Select(x => x.FirstId)
                    //    .ToListAsync();

                    var D_Users = await _db.D_Users
                        //.Where(x => Users.Contains(x.Id))
                        .Where(x => x.EnableRecord == true)
                        .AsNoTracking()
                        //.Include(x => x.UserLocations)
                        .ToListAsync();

                    long _Location = 0;

                    //if (!eP_Task.Role.Independent)
                    if (true)
                    {
                        var _ConditionId = eP_Task.ConditionId;

                        var _CurrentCondition = await _db.F_Conditions
                            .Where(x => x.Id == _ConditionId).SingleAsync();

                        _Location = long.Parse(Current_Case.Conditions
                            .Where(x => x.Name == _CurrentCondition.Name)
                            .Select(x => x.Value).Single());
                    }

                    foreach (var D_User in D_Users)
                    {
                        var UserOccur = false;

                        //if (eP_Task.Role.Independent)
                        if (false)
                        {
                            UserOccur = true;
                        }
                        else
                        {
                            if (eP_Task.ConditionId is not null)
                            {
                                //if (D_User.UserLocations.Any(x => x.SecondId == _Location))
                                if (true)
                                {
                                    UserOccur = true;
                                }
                            }
                        }
                        if (UserOccur)
                        {
                            F_WorkItem f_WorkItem = new()
                            {
                                Case = Current_Case,
                                TaskId = eP_Task.Id,
                                UserId = D_User.Id
                            };
                            Current_Case.WorkItems.Add(f_WorkItem);
                        }
                    }
                    if (!Current_Case.WorkItems
                      .Where(x => x.TaskId == eP_Task.Id)
                      .Any())
                    {
                        throw new ArgumentNullException($"There aren't any related users for {eP_Task.Name}");
                    }
                }
            }
            if (Current_WorkItem is not null)
            {
                first_WorkItem = Current_WorkItem;
            }

            await SetCurrentAssignment(first_WorkItem);

            return OutputState<Boolean>.Success("با موفقیت ایجاد شد.", true);
        }
        catch (Exception ex)
        {
            throw;
        }
    }
    public async Task<CheetahResult<F_Case>> CreateRequestAsync(F_Case request)
    {
        var GeneralRequest = await _iCopyClass.DeepCopy(request);

        CheetahResult<F_Case> _OutputState = new();

        var DuplicateCase = _db.F_Cases
            .Where(x => x.ProcessId == GeneralRequest.ProcessId)
            .Where(x => x.ERPCode == GeneralRequest.ERPCode)
            .Where(x => x.CaseStateId == D_CaseState.Ongoing.Id || x.CaseStateId == D_CaseState.Editing.Id)
            .Where(x => x.EnableRecord == true)
            .AsNoTracking();

        var CaseID = await DuplicateCase.Select(x => x.Id).FirstOrDefaultAsync();

        if (CaseID is not null)
        {
            _OutputState = OutputState<F_Case>.DuplicateErrorCreateRequest(CaseID, GeneralRequest);

            return _OutputState;
        }

        _db.F_Cases.Add(GeneralRequest);

        await SetWorkItemsAsync(GeneralRequest);

        await _db.SaveChangesAsync();

        var log = new LoggerConfiguration()
                     .WriteTo.Console()
                     .WriteTo.File("Serilog.txt")
                     .CreateLogger();

        _OutputState = OutputState<F_Case>.SuccessCreateRequest(GeneralRequest.Id, GeneralRequest);

        log.Information($"CreateRequestAsync-{GeneralRequest.Id}");

        return _OutputState;
    }
    public async Task<CheetahResult<F_WorkItem>> PerformWorkItemAsync(F_WorkItem f_WorkItem, Boolean Rebase = false)
    {
        CheetahResult<F_WorkItem> _OutputState = new();

        var Current_WorkItem = await _db.F_WorkItems
              .Where(x => x.Id == f_WorkItem.Id)
              .Include(x => x.Case)
              .ThenInclude(x => x.WorkItems)
              .ThenInclude(x => x.Task)
              .Include(x => x.Case)
              .ThenInclude(x => x.Conditions)
              .FirstAsync();

        Current_WorkItem.Case.Conditions = await _iCopyClass.CopyCondition(f_WorkItem.Case.Conditions);

        if (Current_WorkItem.LastModified is not null && Rebase == false)
        {
            _OutputState = OutputState<F_WorkItem>.PreviouslySentErrorCreateRequest(Current_WorkItem.Id, Current_WorkItem);

            return _OutputState;
        }

        var _currentAssignment = await SetCurrentAssignment(Current_WorkItem);

        if (Current_WorkItem.Case.IsEditing())
        {
            Current_WorkItem.Case.WorkItems
                .Where(x => !x.IsExit() && !x.IsSent())
                .ToList().ForEach(x => x.SetExit());

            await SetWorkItemsAsync(Current_WorkItem.Case, Current_WorkItem);
        }

        _db.F_WorkItems.Update(_currentAssignment.Result.Value);

        await _db.SaveChangesAsync();

        _OutputState = OutputState<F_WorkItem>.SuccessPerformWorkItem(Current_WorkItem.Id, Current_WorkItem);

        return _OutputState;
    }
    public CheetahResult<bool> CompareCondition(IEnumerable<F_Condition> Actual_Conditions, IEnumerable<F_Condition> Expected_Conditions)
    {
        var cnt_con = Expected_Conditions.Count();

        var ConditionOccur = 0;

        for (int i = 0; i < cnt_con; i++)
        {
            var Condition = Expected_Conditions.ToArray()[i];

            if (Actual_Conditions.Any(x => x.TagId == Condition.TagId))
            {
                var Scenario_Value = float.Parse(Condition.Value);
                var Current_Value = float.Parse(Actual_Conditions
                    .Single(x => x.TagId == Condition.TagId).Value);

                var Operand_Name = Condition.Operand.Name;

                switch (Operand_Name)
                {
                    case string Greater when Current_Value > Scenario_Value && Greater == D_Operand.Greater.Name:
                    case string EqualAndGreater when Current_Value >= Scenario_Value && EqualAndGreater == D_Operand.EqualAndGreater.Name:
                    case string LessThan when Current_Value < Scenario_Value && LessThan == D_Operand.LessThan.Name:
                    case string LessThanOrEqual when Current_Value <= Scenario_Value && LessThanOrEqual == D_Operand.LessThanOrEqual.Name:
                    case string Equals when Current_Value == Scenario_Value && Equals == D_Operand.Equals.Name:
                    case string NotEquals when Current_Value != Scenario_Value && NotEquals == D_Operand.NotEquals.Name:
                        ConditionOccur++;
                        break;
                }


            }
        }
        CheetahResult<bool> _OutputState = new();

        if (ConditionOccur == cnt_con)
        {
            _OutputState = OutputState<bool>.Success("همانند است", true);
        }
        else
        {
            _OutputState = OutputState<bool>.Success("همانند نیست", false);
        }
        return _OutputState;
    }
    public async Task<CheetahResult<F_WorkItem>> SetCurrentAssignment(F_WorkItem Current_WorkItem)
    {
        Current_WorkItem.Case.LastModified = DateTimeOffset.Now;

        var WorkItemTaskId = Current_WorkItem.TaskId;

        var WorkItemTask = await _db.F_Tasks
            .Where(x => x.Id == Current_WorkItem.TaskId)
            .SingleAsync();

        var ActualConditions = Current_WorkItem.Case.Conditions;

        var TaskItems = await _db.L_TaskActions
           .Where(x => x.FirstId == WorkItemTaskId)
           .Select(x => x.Action)
           .ToListAsync();

        foreach (var TaskItem in TaskItems)
        {
            var ExpectedConditions = TaskItem.Conditions;

            foreach (var ExpectedCondition in ExpectedConditions)
            {
                var ExpectedConditionList = new List<F_Condition>();

                ExpectedConditionList.Add(ExpectedCondition);


                if (CompareCondition(ActualConditions, ExpectedConditionList).Result.Value)
                {

                    Current_WorkItem.Case.CaseStateId =
                        TaskItem.CaseStateId;

                    Current_WorkItem.Conditions = ActualConditions;

                    Current_WorkItem.SetSent();

                    if (Current_WorkItem.Case.IsAborted())
                    {
                        Current_WorkItem.Case.WorkItems
                            .Where(x => !x.IsExit() && !x.IsSent())
                            .ToList().ForEach(x => x.SetExit());
                    }

                    if (!Current_WorkItem.Case.IsAborted())
                    {
                        #region Exit Current work items

                        if (Current_WorkItem.CaseId.HasValue)
                        {
                            var OtherWorkItems = Current_WorkItem.Case.WorkItems
                                .Where(x => x.Task is not null)
                                .Where(x => x.Task.SortIndex <= WorkItemTask.SortIndex)
                                .Where(x => x.IsInbox() || x.IsFuture());

                            foreach (var OtherWorkItem in OtherWorkItems)
                            {
                                OtherWorkItem.SetExit();
                            }
                        }
                        #endregion

                        #region Set inbox

                        var toTasks = TaskItem?.TaskAction?
                            .Select(x => x.Task);

                        foreach (var toTask in toTasks)
                        {
                            var _Current_WorkItems =
                                Current_WorkItem.Case.WorkItems
                                .Where(x => x.TaskId == toTask.Id)
                                .Where(x => !x.IsSent() && !x.IsExit());


                            var _caseTaskUsers = await _db.L_CaseTaskUsers
                                .Where(x => x.Case.Id == Current_WorkItem.CaseId)
                                .Where(x => x.Task.Id == toTask.Id)
                                .ToListAsync();

                            if (_caseTaskUsers.Any())
                            {
                                var _users = _caseTaskUsers.Select(x => x.User?.Id.Value);

                                _Current_WorkItems
                                    .Where(x => _users.Any(y => y == x.UserId))
                                    .ToImmutableList()
                                    .ForEach(x => x.SetInbox());

                                _Current_WorkItems
                                    .Where(x => !_users.Any(y => y == x.UserId))
                                    .ToImmutableList()
                                    .ForEach(x => x.SetExit());
                            }
                            else
                            {
                                _Current_WorkItems
                                    .ToList()
                                    .ForEach(x => x.SetInbox());
                            }
                            #endregion
                        }

                        Current_WorkItem.Case.WorkItems
                        .Where(x => x.WorkItemStateId is null)
                        .ToList().ForEach(x => x.SetFuture());
                    }


                }
            }
        }

        return OutputState<F_WorkItem>.Success("با موفقیت ایجاد شد", Current_WorkItem);
    }
    public async Task<CheetahResult<L_CaseTaskUser>> SetCaseTaskUser(L_CaseTaskUser CaseTaskUser)
    {
        var _CaseTaskUser = await _iCopyClass.DeepCopy(CaseTaskUser);

        var _selectedCaseTaskUsers = _db.L_CaseTaskUsers
            .Where(x => x.Case.Id == CaseTaskUser.Case.Id)
            .Where(x => x.Task.Id == CaseTaskUser.Task.Id);

        var _result = _selectedCaseTaskUsers
            .Include(x => x.Case)
            .Include(x => x.Task)
            .Include(x => x.User);

        if (!await _selectedCaseTaskUsers.AnyAsync())
        {
            await _db.L_CaseTaskUsers.AddAsync(_CaseTaskUser);

            await _db.SaveChangesAsync();
        }

        var _caseTaskUsers = await _result.FirstOrDefaultAsync();

        return OutputState<L_CaseTaskUser>.Success("با موفقیت ایجاد شد", _caseTaskUsers);
    }
}