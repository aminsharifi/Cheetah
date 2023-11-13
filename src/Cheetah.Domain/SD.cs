using Cheetah.Resx;

namespace Cheetah.Domain;
public class CPersianClass
{
    public IGlobalization iGlobalization = new Globalization(nameof(Cheetah) + "." + nameof(Cheetah.Domain));
    public string GetPersianDate(DateTime? date)
    {
        if (date.HasValue)
        {
            PersianCalendar p = new PersianCalendar();
            var CDate = p.GetYear(date.Value) + "/" + p.GetMonth(date.Value) + "/" + p.GetDayOfMonth(date.Value);
            var CTime = date.Value.ToString("HH:mm");
            return CTime + " " + CDate;
        }
        else
            return String.Empty;
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
    CString,
    CBool,
    CSelect
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
    public IGlobalization iGlobalization = new Globalization(nameof(Cheetah) + "." + nameof(Cheetah.Domain));

    public KeyValuePair<CrudOperation, String> GetPageTitle(long? id)
    {
        if (id == 0)
        {
            return new KeyValuePair<CrudOperation, string>(CrudOperation.Create, iGlobalization.GetValue(Resx.Localization.Domain_Create));
        }
        else
        {
            return new KeyValuePair<CrudOperation, string>(CrudOperation.Update, iGlobalization.GetValue(Resx.Localization.Domain_Update));
        }
    }
}