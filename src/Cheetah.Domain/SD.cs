namespace Cheetah.Domain;
public class CPersianClass
{
    public string GetPersianDate(DateTime? date)
    {
        if (!date.HasValue)
            return String.Empty;

        PersianCalendar p = new ();
        var CDate = p.GetYear(date.Value) + "/" + p.GetMonth(date.Value) + "/" + p.GetDayOfMonth(date.Value);
        var CTime = date.Value.ToString("HH:mm");
        return CTime + " " + CDate; 

    }
}
public enum CartableProperty
{
    Inbox,
    Outbox
}
public enum RoleProperty
{
    Admin,
    User
}
public enum LinkProperty
{
    First,
    Second
}
public enum TableType
{
    Dimentions,
    Links,
    Facts,
    Virtuals
}
public enum FieldType
{
    CID,
    CInt,
    CNInt,
    CFloat,
    CNFloat,
    CString,
    CBool,
    CSelect,
    CDate
}
public enum CrudOperation
{
    Create,
    Read,
    Update,
    Delete
}

public class UpsertStatus
{
    public IGlobalization iGlobalization = new Globalization(nameof(Cheetah) + "." + nameof(Domain));

    public KeyValuePair<CrudOperation, String> GetPageTitle(long? id)
    {
        if (id == 0)
        {
            return new KeyValuePair<CrudOperation, string>(CrudOperation.Create, GlobalizationService.GetValue(Localization.Domain_Create));
        }
        else
        {
            return new KeyValuePair<CrudOperation, string>(CrudOperation.Update, GlobalizationService.GetValue(Localization.Domain_Update));
        }
    }
}