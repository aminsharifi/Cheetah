using Cheetah_Common;
using System.Collections;

namespace Cheetah_DataAccess.Data
{
    public class DatabaseClass
    {
        public DatabaseClass() { }
        public static TableType GetTableType(String dBType)
        {
            return dBType.StartsWith("D") ? TableType.Dimentions : dBType.StartsWith("L") ?
                TableType.Links : TableType.Facts;
        }
        public static Type GetDBType(String dBType)
        {
            String schema = GetTableType(dBType).ToString();
            return Type.GetType("Cheetah_DataAccess." + schema + "." + dBType + ",Cheetah_DataAccess");
        }
        public static IEnumerable InvokeSet(ApplicationDbContext _db, Type gtype)
        {
            var method = _db.GetType().GetMethod("Set", new Type[0]).MakeGenericMethod(gtype);

            return method.Invoke(_db, new object[0]) as IEnumerable;
        }
    }
}
