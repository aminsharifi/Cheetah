
namespace Cheetah.Presentation.Services.gRPC.Helper;

public static class CgRPC
{
    public static Timestamp CGetTimestamp(this DateTimeOffset? dateTime)
    {
        if (!dateTime.HasValue)
        {
            return null;
        }
        return dateTime.Value.ToTimestamp();
    }
    public static GRPC_BaseClass GetBaseClass(this SimpleClass simpleClass)
    {
        GRPC_BaseClass _GRPC_BaseClass = new();

        if (simpleClass is null)
        {
            return _GRPC_BaseClass;
        }
        _GRPC_BaseClass = new()
        {
            Id = simpleClass.Id.HasValue ? simpleClass.Id.Value : 0,
            ERPCode = simpleClass.ERPCode.HasValue ? simpleClass.ERPCode.Value : 0,
            SortIndex = simpleClass.SortIndex.HasValue ? simpleClass.SortIndex.Value : 0
        };

        return _GRPC_BaseClass;
    }
    public static GRPC_BaseClassWithName GetBaseClassWithName(this SimpleClass simpleClass)
    {
        GRPC_BaseClassWithName _GRPC_BaseClass = new();

        if (simpleClass is null)
        {
            return _GRPC_BaseClass;
        }
        _GRPC_BaseClass = new()
        {
            Id = simpleClass.Id.HasValue ? simpleClass.Id.Value : 0,
            ERPCode = simpleClass.ERPCode.HasValue ? simpleClass.ERPCode.Value : 0,
            SortIndex = simpleClass.SortIndex.HasValue ? simpleClass.SortIndex.Value : 0,
            Name = (simpleClass.Name is not null) ? simpleClass.Name : String.Empty,
            DisplayName = (simpleClass.DisplayName is not null) ? simpleClass.DisplayName : String.Empty
        };

        return _GRPC_BaseClass;
    }
    public static GRPC_BaseClassWithDate GetBaseClassWithDate(this SimpleClass simpleClass)
    {
        GRPC_BaseClassWithDate _GRPC_BaseClass = new();

        if (simpleClass is null)
        {
            return _GRPC_BaseClass;
        }
        _GRPC_BaseClass = new()
        {
            Id = simpleClass.Id.HasValue ? simpleClass.Id.Value : 0,
            ERPCode = simpleClass.ERPCode.HasValue ? simpleClass.ERPCode.Value : 0,
            SortIndex = simpleClass.SortIndex.HasValue ? simpleClass.SortIndex.Value : 0,
            CreateTimeRecord = simpleClass.CreateTimeRecord.CGetTimestamp(),
            LastUpdatedRecord = simpleClass.LastUpdatedRecord.CGetTimestamp()
        };



        return _GRPC_BaseClass;
    }
    public static GRPC_BaseClassWithNameAndDate GetBaseClassWithNameAndDate(this SimpleClass simpleClass)
    {
        GRPC_BaseClassWithNameAndDate _GRPC_BaseClass = new();

        if (simpleClass is null)
        {
            return _GRPC_BaseClass;
        }
        _GRPC_BaseClass = new()
        {
            Id = simpleClass.Id.HasValue ? simpleClass.Id.Value : 0,
            ERPCode = simpleClass.ERPCode.HasValue ? simpleClass.ERPCode.Value : 0,
            SortIndex = simpleClass.SortIndex.HasValue ? simpleClass.SortIndex.Value : 0,
            Name = (simpleClass.Name is not null) ? simpleClass.Name : String.Empty,
            DisplayName = (simpleClass.DisplayName is not null) ? simpleClass.DisplayName : String.Empty,
            CreateTimeRecord = simpleClass.CreateTimeRecord.CGetTimestamp(),
            LastUpdatedRecord = simpleClass.LastUpdatedRecord.CGetTimestamp()
        };

        return _GRPC_BaseClass;
    }
    public static GRPC_BaseClass GetBaseClass(this SimpleClassDTO simpleClass)
    {
        var _GRPC_BaseClass = new GRPC_BaseClass();

        if (simpleClass is null)
        {
            return _GRPC_BaseClass;
        }

        _GRPC_BaseClass = new GRPC_BaseClass()
        {
            Id = simpleClass.Id.HasValue ? simpleClass.Id.Value : 0,
            ERPCode = simpleClass.ERPCode.HasValue ? simpleClass.ERPCode.Value : 0,
            SortIndex = simpleClass.SortIndex.HasValue ? simpleClass.SortIndex.Value : 0
        };

        return _GRPC_BaseClass;
    }
    public static GRPC_BaseClassWithName GetBaseClassWithName(this SimpleClassDTO simpleClass)
    {
        var _GRPC_BaseClass = new GRPC_BaseClassWithName();

        if (simpleClass is null)
        {
            return _GRPC_BaseClass;
        }

        _GRPC_BaseClass = new GRPC_BaseClassWithName()
        {
            Id = simpleClass.Id.HasValue ? simpleClass.Id.Value : 0,
            ERPCode = simpleClass.ERPCode.HasValue ? simpleClass.ERPCode.Value : 0,
            SortIndex = simpleClass.SortIndex.HasValue ? simpleClass.SortIndex.Value : 0,
            Name = (simpleClass.Name is not null) ? simpleClass.Name : String.Empty,
            DisplayName = (simpleClass.DisplayName is not null) ? simpleClass.DisplayName : String.Empty
        };

        return _GRPC_BaseClass;
    }
    public static GRPC_BaseClassWithNameAndDate GetBaseClassWithNameAndDate(this SimpleClassDTO simpleClass)
    {
        var _GRPC_BaseClass = new GRPC_BaseClassWithNameAndDate();

        if (simpleClass is null)
        {
            return _GRPC_BaseClass;
        }

        _GRPC_BaseClass = new GRPC_BaseClassWithNameAndDate()
        {
            Id = simpleClass.Id.HasValue ? simpleClass.Id.Value : 0,
            ERPCode = simpleClass.ERPCode.HasValue ? simpleClass.ERPCode.Value : 0,
            SortIndex = simpleClass.SortIndex.HasValue ? simpleClass.SortIndex.Value : 0,
            Name = (simpleClass.Name is not null) ? simpleClass.Name : String.Empty,
            DisplayName = (simpleClass.DisplayName is not null) ? simpleClass.DisplayName : String.Empty
        };

        _GRPC_BaseClass.CreateTimeRecord =
            simpleClass.CreateTimeRecord.CGetTimestamp();

        _GRPC_BaseClass.LastUpdatedRecord =
            simpleClass.LastUpdatedRecord.CGetTimestamp();

        return _GRPC_BaseClass;
    }
    public static T GetSimpleClass<T>(this GRPC_BaseClassWithNameAndDate gRPC_BaseClass) where T : SimpleClass
    {
        if (gRPC_BaseClass is null)
        {
            return null;
        }

        var _SimpleClass = (T)Activator.CreateInstance(typeof(T));

        if (gRPC_BaseClass.Id is not null)
        {
            _SimpleClass.Id = gRPC_BaseClass.Id;
        }
        if (gRPC_BaseClass.ERPCode is not null)
        {
            _SimpleClass.ERPCode = gRPC_BaseClass.ERPCode;
        }
        if (gRPC_BaseClass.SortIndex is not null)
        {
            _SimpleClass.SortIndex = gRPC_BaseClass.SortIndex;
        }
        if (gRPC_BaseClass.Name is not null)
        {
            _SimpleClass.Name = gRPC_BaseClass.Name;
        }
        if (gRPC_BaseClass.CreateTimeRecord is not null)
        {
            _SimpleClass.CreateTimeRecord = gRPC_BaseClass.CreateTimeRecord.ToDateTime();
        }
        if (gRPC_BaseClass.LastUpdatedRecord is not null)
        {
            _SimpleClass.LastUpdatedRecord = gRPC_BaseClass.LastUpdatedRecord.ToDateTime();
        }

        return _SimpleClass;
    }
    public static T GetSimpleClass<T>(this GRPC_BaseClassWithName gRPC_BaseClass) where T : SimpleClass
    {
        if (gRPC_BaseClass is null)
        {
            return null;
        }

        var _SimpleClass = (T)Activator.CreateInstance(typeof(T));

        if (gRPC_BaseClass.Id is not null)
        {
            _SimpleClass.Id = gRPC_BaseClass.Id;
        }
        if (gRPC_BaseClass.ERPCode is not null)
        {
            _SimpleClass.ERPCode = gRPC_BaseClass.ERPCode;
        }
        if (gRPC_BaseClass.SortIndex is not null)
        {
            _SimpleClass.SortIndex = gRPC_BaseClass.SortIndex;
        }
        if (gRPC_BaseClass.Name is not null)
        {
            _SimpleClass.Name = gRPC_BaseClass.Name;
        }

        return _SimpleClass;
    }
    public static T GetSimpleClass<T>(this GRPC_BaseClass gRPC_BaseClass) where T : SimpleClass
    {
        if (gRPC_BaseClass is null)
        {
            return null;
        }

        var _SimpleClass = (T)Activator.CreateInstance(typeof(T));

        if (gRPC_BaseClass.Id is not null)
        {
            _SimpleClass.Id = gRPC_BaseClass.Id;
        }
        if (gRPC_BaseClass.ERPCode is not null)
        {
            _SimpleClass.ERPCode = gRPC_BaseClass.ERPCode;
        }
        if (gRPC_BaseClass.SortIndex is not null)
        {
            _SimpleClass.SortIndex = gRPC_BaseClass.SortIndex;
        }

        return _SimpleClass;
    }
    public static IEnumerable<F_Condition> GetCondition(this IEnumerable<Condition> Conditions)
    {
        foreach (var Condition in Conditions)
        {
            var f_Condition = new F_Condition();

            if (Condition.Base is not null)
            {
                f_Condition.Id = Condition.Base.Id;
                f_Condition.Name = Condition.Base.Name;
                f_Condition.ERPCode = Condition.Base.ERPCode;
                f_Condition.SortIndex = Condition.Base.SortIndex;
            }

            if (Condition.Tag is not null)
            {
                f_Condition.Tag = Condition?.Tag?.GetSimpleClass<D_Tag>();
            }
            if (Condition.Operand is not null)
            {
                f_Condition.Operand = Condition?.Operand?.GetSimpleClass<D_Operand>();
            }
            if (Condition.Value is not null)
            {
                f_Condition.Value = Condition.Value;
            }

            yield return f_Condition;
        }
    }

}