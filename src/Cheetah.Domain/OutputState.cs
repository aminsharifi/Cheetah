namespace Cheetah.Domain;

public static class OutputState<T>
{
    #region Success
    public static CheetahResult<T> Success(String DisplayName, T input)
    {
        var _Result = Result.Success(input);

        var _OutputState = new CheetahResult<T>() { Result = _Result };

        _OutputState.SimpleClassDTO = new(Id: 0, Name: GlobalizationService.GetValue(Localization.Domain_Success),
        DisplayName: DisplayName, SortIndex: 0, ERPCode: 0);

        return _OutputState;
    }
    public static CheetahResult<T> SuccessCreateRequest(long? CaseID, T input)
    {
        var DisplayName = GlobalizationService.GetValue(nameof(Localization.Domain_SuccessCreateRequest), new Object[] { CaseID });

        var _OutputState = OutputState<T>.Success(DisplayName, input);

        return _OutputState;
    }
    public static CheetahResult<T> SuccessPerformWorkItem(long? WorkItemID, T input)
    {
        var DisplayName = GlobalizationService.GetValue(nameof(Localization.Domain_SuccessPerformWorkItem), new Object[] { WorkItemID });

        var _OutputState = OutputState<T>.Success(DisplayName, input);

        return _OutputState;
    }

    #endregion

    #region Errors   
    public static CheetahResult<T> DuplicateErrorCreateRequest(long? CaseID, T input)
    {
        var _Name = nameof(Localization.Domain_DuplicateErrorCreateRequest);

        var DisplayName = GlobalizationService.GetValue(_Name, new Object[] { CaseID });

        var _Result = Result.Conflict(_Name);

        var _OutputState = new CheetahResult<T>() { Result = _Result };

        _OutputState.SimpleClassDTO = new(Id: 1, Name: _Name,
        DisplayName: DisplayName, SortIndex: 1, ERPCode: 1);

        return _OutputState;
    }
    public static CheetahResult<T> NotFoundErrorCreateRequest(T input)
    {
        var _Name = nameof(Localization.Domain_NotFound);

        var DisplayName = GlobalizationService.GetValue(_Name);

        var _Result = Result.NotFound(_Name);

        var _OutputState = new CheetahResult<T>() { Result = _Result };

        _OutputState.SimpleClassDTO = new(Id: 2, Name: _Name,
        DisplayName: DisplayName, SortIndex: 2, ERPCode: 2);

        return _OutputState;
    }
    public static CheetahResult<T> PreviouslySentErrorCreateRequest(long? workItemId, T input)
    {
        var _Name = nameof(Localization.PreviouslySentError);

        var DisplayName = GlobalizationService.GetValue(_Name, new Object[] { workItemId });

        var _Result = Result<T>.Error(_Name);

        var _OutputState = new CheetahResult<T>() { Result = _Result };

        _OutputState.SimpleClassDTO = new(Id: 3, Name: _Name,
            DisplayName: DisplayName, SortIndex: 3, ERPCode: 3);

        return _OutputState;
    }
    #endregion
}