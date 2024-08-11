using Cheetah.Core.Common;
using Cheetah.Core.Enums;

namespace Cheetah.Infrastructure.Data;
public class DatabaseClass
{
    public static TableType GetTableType(string dBType)
    {
        return dBType.StartsWith("D") ? TableType.Dimentions : dBType.StartsWith("L") ?
            TableType.Links : TableType.Facts;
    }
    public static Type GetDBType(string dBType)
    {
        var _schema = nameof(Core.Entities) + "." + GetTableType(dBType).ToString();
        var _namespace = nameof(Cheetah) + "." + nameof(Core);
        var _returnType = Type.GetType(_namespace + "." + _schema + "." + dBType + "," + _namespace);

        return _returnType;
    }
    public static IQueryable<BaseEntity> InvokeSet(CheetahDbContext _db, Type gtype)
    {
        var method = _db.GetType().GetMethod("Set", new Type[0]).MakeGenericMethod(gtype);

        return method.Invoke(_db, new object[0]) as IQueryable<BaseEntity>;
    }
}