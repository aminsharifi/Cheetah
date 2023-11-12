namespace Cheetah.Domain;

public static class OutputState<T>
{
    #region Success
    public static CheetahResult<T> Success(String DisplayName, T input)
    {
        ResourceManager resourceManager =
        new ResourceManager("Localization", Assembly.Load("App_GlobalResources"));
        string myString = resourceManager.GetString("Success_Message");

        var _Result = Result.Ok(input);

        var _OutputState = new CheetahResult<T>() { Result = _Result };
        _OutputState.SimpleClassDTO.Id = 0;
        _OutputState.SimpleClassDTO.ERPCode = 0;
        _OutputState.SimpleClassDTO.Name = "Success";
        _OutputState.SimpleClassDTO.DisplayName = DisplayName;

        return _OutputState;
    }
    public static CheetahResult<T> SuccessCreateRequest(long? CaseID, T input)
    {
        var DisplayName = $"درخواست با شماره رهیگری {CaseID} با موفقیت در چیتا ثبت شد ";

        var _OutputState = OutputState<T>.Success(DisplayName, input);

        return _OutputState;
    }
    public static CheetahResult<T> SuccessPerformWorkItem(long? WorkItemID, T input)
    {
        var DisplayName = $"درخواست با شماره کار {WorkItemID} با موفقیت در چیتا ارسال شد";

        var _OutputState = OutputState<T>.Success(DisplayName, input);

        return _OutputState;
    }

    #endregion
    #region Errors
    public static CheetahResult<T> DuplicateError(String DisplayName, T input)
    {
        var _Result = Result.Fail("Duplicate");

        var _OutputState = new CheetahResult<T>() { Result = _Result };
        _OutputState.SimpleClassDTO.Id = 1;
        _OutputState.SimpleClassDTO.ERPCode = 1;
        _OutputState.SimpleClassDTO.Name = "Duplicate";
        _OutputState.SimpleClassDTO.DisplayName = DisplayName;
        return _OutputState;
    }
    public static CheetahResult<T> DuplicateErrorCreateRequest(long? CaseID, T input)
    {
        var DisplayName = $"درخواست پیشین با شماره رهیگری {CaseID} در چیتا ثبت شده است";
        var _OutputState = OutputState<T>.DuplicateError(DisplayName, input);
        return _OutputState;
    }

    #endregion
}