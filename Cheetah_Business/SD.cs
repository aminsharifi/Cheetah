using System.Reflection.Metadata.Ecma335;

namespace Cheetah_Business
{
    public enum LinkProperty
    {
        First,
        Second
    }
    public enum TableType
    {
        Dimentions,
        Links,
        Facts
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
}
