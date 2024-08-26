using Cheetah.Core.Common;
using Cheetah.Core.Enums;
using System;
using static Azure.Core.HttpHeader;

namespace Cheetah.Infrastructure.Data;
public class DatabaseClass
{
    public static TableType GetTableType(string dBType)
    {
        return dBType.StartsWith("D") ? TableType.Dimentions : dBType.StartsWith("L") ?
            TableType.Links : TableType.Facts;
    }
    public static Type GetDBType(string tableName)
    {
        var _namespace = nameof(Cheetah) + "." + nameof(Core);
        var _schema = nameof(Core.Aggregates);
        var _aggregateType  = nameof(Core.Aggregates.Common);
        
        var _type = GetTableType(tableName).ToString();    
        Type _returnType = default;
        Action _action = () => { _returnType = Type.GetType(_namespace + "." + _schema + "." + _aggregateType + "." + _type + "." + tableName + "," + _namespace); };

        _action();
        if (_returnType == null)
        {
            _aggregateType = nameof(Core.Aggregates.CaseAggregate);
            _action();
        }
        if (_returnType == null)
        {
            _aggregateType = nameof(Core.Aggregates.ConditionAggregate);
            _action();
        }
        if (_returnType == null)
        {
            _aggregateType = nameof(Core.Aggregates.ProcessAggregate);
            _action();
        }
        if (_returnType == null)
        {
            _aggregateType = nameof(Core.Aggregates.UserAggregate);
            _action();
        }
        return _returnType;
    }
    public static IQueryable<BaseEntity> InvokeSet(CheetahDbContext _db, Type gtype)
    {
        var method = _db.GetType().GetMethod("Set", new Type[0]).MakeGenericMethod(gtype);

        return method.Invoke(_db, new object[0]) as IQueryable<BaseEntity>;
    }
}