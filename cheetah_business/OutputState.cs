using Cheetah.Domain.Data;

namespace Cheetah.Domain;
public static class OutputState
{
    #region Success
    public static SimpleClassDTO Success(String DisplayName)
    {
        SimpleClassDTO OutputState = new();
        OutputState.Id = 0;
        OutputState.ERPCode = 0;
        OutputState.Name = "Success";
        OutputState.DisplayName = DisplayName;
        return OutputState;
    }
    public static SimpleClassDTO SuccessCreateRequest(long? CaseID)
    {
        var DisplayName = $"درخواست با شماره رهیگری {CaseID} با موفقیت در چیتا ثبت شد ";
        var _OutputState = Success(DisplayName);
        return _OutputState;
    }
    public static SimpleClassDTO SuccessPerformWorkItem(long? WorkItemID)
    {
        var DisplayName = $"درخواست با شماره کار {WorkItemID} با موفقیت در چیتا ارسال شد";
        var _OutputState = Success(DisplayName);
        return _OutputState;
    }

    #endregion
    #region Errors
    public static SimpleClassDTO DuplicateError(String DisplayName)
    {
        SimpleClassDTO OutputState = new();
        OutputState.Id = 1;
        OutputState.ERPCode = 1;
        OutputState.Name = "Duplicate";
        OutputState.DisplayName = DisplayName;
        return OutputState;
    }
    public static SimpleClassDTO DuplicateErrorCreateRequest(long? CaseID)
    {
        var DisplayName = $"درخواست پیشین با شماره رهیگری {CaseID} در چیتا ثبت شده است";
        var _OutputState = DuplicateError(DisplayName);
        return _OutputState;
    }

    #endregion
}