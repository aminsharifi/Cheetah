namespace Cheetah.Presentation.Services.gRPC.Helper;

public static class CgRPC
{
    public static Timestamp CGetTimestamp(this DateTime? dateTime)
    {
        if (!dateTime.HasValue)
        {
            return null;
        }
        return Timestamp.FromDateTime
                     (DateTime.SpecifyKind(dateTime.Value, DateTimeKind.Utc));
    }
    public static GRPC_BaseClass GetBaseClass(this SimpleClass simpleClass)
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
        };

        return _GRPC_BaseClass;
    }
    public static GRPC_BaseClassWithName GetBaseClassWithName(this SimpleClass simpleClass)
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
            Name = (simpleClass.Name is not null) ? simpleClass.Name : String.Empty,
            DisplayName = (simpleClass.DisplayName is not null) ? simpleClass.DisplayName : String.Empty
        };

        return _GRPC_BaseClass;
    }
    public static GRPC_BaseClassWithNameAndDate GetBaseClassWithNameAndDate(this SimpleClass simpleClass)
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
            Name = (simpleClass.Name is not null) ? simpleClass.Name : String.Empty,
            DisplayName = (simpleClass.DisplayName is not null) ? simpleClass.DisplayName : String.Empty
        };

        _GRPC_BaseClass.CreateTimeRecord = simpleClass.CreateTimeRecord.CGetTimestamp();

        _GRPC_BaseClass.LastUpdatedRecord = simpleClass.LastUpdatedRecord.CGetTimestamp();

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
            Name = (simpleClass.Name is not null) ? simpleClass.Name : String.Empty,
            DisplayName = (simpleClass.DisplayName is not null) ? simpleClass.DisplayName : String.Empty
        };

        _GRPC_BaseClass.CreateTimeRecord =
            simpleClass.CreateTimeRecord.CGetTimestamp();

        _GRPC_BaseClass.LastUpdatedRecord =
            simpleClass.LastUpdatedRecord.CGetTimestamp();

        return _GRPC_BaseClass;
    }
    public static SimpleClass GetSimpleClass(this GRPC_BaseClassWithNameAndDate gRPC_BaseClass, System.Type type)
    {
        if (gRPC_BaseClass is null)
        {
            return null;
        }

        var _SimpleClass = (SimpleClass)Activator.CreateInstance(type);

        if (gRPC_BaseClass.Id is not null)
        {
            _SimpleClass.Id = gRPC_BaseClass.Id;
        }
        if (gRPC_BaseClass.ERPCode is not null)
        {
            _SimpleClass.ERPCode = gRPC_BaseClass.ERPCode;
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
    public static SimpleClass GetSimpleClass(this GRPC_BaseClassWithName gRPC_BaseClass, System.Type type)
    {
        if (gRPC_BaseClass is null)
        {
            return null;
        }

        var _SimpleClass = (SimpleClass)Activator.CreateInstance(type);

        if (gRPC_BaseClass.Id is not null)
        {
            _SimpleClass.Id = gRPC_BaseClass.Id;
        }
        if (gRPC_BaseClass.ERPCode is not null)
        {
            _SimpleClass.ERPCode = gRPC_BaseClass.ERPCode;
        }
        if (gRPC_BaseClass.Name is not null)
        {
            _SimpleClass.Name = gRPC_BaseClass.Name;
        }

        return _SimpleClass;
    }
    public static SimpleClass GetSimpleClass(this GRPC_BaseClass gRPC_BaseClass, System.Type type)
    {
        if (gRPC_BaseClass is null)
        {
            return null;
        }

        var _SimpleClass = (SimpleClass)Activator.CreateInstance(type);

        if (gRPC_BaseClass.Id is not null)
        {
            _SimpleClass.Id = gRPC_BaseClass.Id;
        }
        if (gRPC_BaseClass.ERPCode is not null)
        {
            _SimpleClass.ERPCode = gRPC_BaseClass.ERPCode;
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
            }

            if (Condition.Tag is not null)
            {
                f_Condition.Tag = new D_Tag() { ERPCode = Condition?.Tag?.ERPCode };
            }
            if (Condition.Operand is not null)
            {
                f_Condition.Operand = new D_Operand() { ERPCode = Condition?.Operand?.ERPCode };
            }
            if (Condition.Value is not null)
            {
                f_Condition.Value = Condition.Value;
            }

            yield return f_Condition;
        }
    }

}
