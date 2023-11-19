namespace Cheetah.Domain;

public static class OutputState<T>
{
    #region Success
    public static CheetahResult<T> Success(String DisplayName, T input)
    {
        var _Result = Result.Ok(input);

        var _OutputState = new CheetahResult<T>() { Result = _Result };
        _OutputState.SimpleClassDTO.Id = 0;
        _OutputState.SimpleClassDTO.ERPCode = 0;
        _OutputState.SimpleClassDTO.Name = GlobalizationService.GetValue(Localization.Domain_Success);
        _OutputState.SimpleClassDTO.DisplayName = DisplayName;

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

        var _Result = Result.Fail(_Name);

        var _OutputState = new CheetahResult<T>() { Result = _Result };

        _OutputState.SimpleClassDTO.Id = 1;
        _OutputState.SimpleClassDTO.ERPCode = 1;
        _OutputState.SimpleClassDTO.Name = _Name;
        _OutputState.SimpleClassDTO.DisplayName = DisplayName;
        
        return _OutputState;
    }

    #endregion
}