namespace Cheetah.Infrastructure.Persistence;

public class DatabaseClass
{
    public static TableType GetTableType(String dBType)
    {
        return dBType.StartsWith("D") ? TableType.Dimentions : dBType.StartsWith("L") ?
            TableType.Links : TableType.Facts;
    }
    public static Type GetDBType(String dBType)
    {
        var _schema = GetTableType(dBType).ToString();
        var _namespace = nameof(Cheetah) + "." + nameof(Cheetah.Domain);
        var _returnType = Type.GetType(_namespace + "." + _schema + "." + dBType + "," + _namespace);
        return _returnType;
    }
    public static IQueryable<SimpleClass> InvokeSet(ApplicationDbContext _db, Type gtype)
    {
        var method = _db.GetType().GetMethod("Set", new Type[0]).MakeGenericMethod(gtype);

        return method.Invoke(_db, new object[0]) as IQueryable<SimpleClass>;
    }
}