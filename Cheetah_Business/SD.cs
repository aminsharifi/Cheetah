using System.Globalization;

namespace Cheetah_Business;

public class CPersianClass
{
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

public struct UpsertStatus
{
    public KeyValuePair<CrudOperation, String> GetPageTitle(long? id)
    {
        if (id == 0)
        {
            return new KeyValuePair<CrudOperation, string>(CrudOperation.Create, "ایجاد");
        }
        else
        {
            return new KeyValuePair<CrudOperation, string>(CrudOperation.Update, "ویرایش");
        }
    }
}