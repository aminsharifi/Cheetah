namespace Cheetah.Domain;

public static class OutputState<T>
{
    #region Success
    public static CheetahResult<T> Success(String DisplayName, T input)
    {
        var _Result = Result.Success(input);

        var _OutputState = new CheetahResult<T>() { Result = _Result };

        _OutputState.SimpleClassDTO = new(id: 0, name: GlobalizationService.GetValue(Localization.Domain_Success),
        displayName: DisplayName, sortIndex: 0, eRPCode: 0);

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

        _OutputState.SimpleClassDTO = new(id: 1, name: _Name,
        displayName: DisplayName, sortIndex: 1, eRPCode: 1);

        return _OutputState;
    }
    public static CheetahResult<T> NotFoundErrorCreateRequest(T input)
    {
        var _Name = nameof(Localization.Domain_NotFound);

        var DisplayName = GlobalizationService.GetValue(_Name);

        var _Result = Result.NotFound(_Name);

        var _OutputState = new CheetahResult<T>() { Result = _Result };

        _OutputState.SimpleClassDTO = new(id: 2, name: _Name,
        displayName: DisplayName, sortIndex: 2, eRPCode: 2);

        return _OutputState;
    }
    public static CheetahResult<T> PreviouslySentErrorCreateRequest(long? workItemId, T input)
    {
        var _Name = nameof(Localization.PreviouslySentError);

        var DisplayName = GlobalizationService.GetValue(_Name, new Object[] { workItemId });

        var _Result = Result<T>.Error(_Name);

        var _OutputState = new CheetahResult<T>() { Result = _Result };

        _OutputState.SimpleClassDTO = new(id: 3, name: _Name,
            displayName: DisplayName, sortIndex: 3, eRPCode: 3);

        return _OutputState;
    }
    #endregion
}