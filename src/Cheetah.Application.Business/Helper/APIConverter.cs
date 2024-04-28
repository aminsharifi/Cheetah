namespace Cheetah.Presentation.Services.WebAPI.Helper;

public static class APIConverter
{
    public static GRPC_BaseClass GetBaseClass(this BaseEntity simpleClass)
    {
        GRPC_BaseClass _GRPC_BaseClass = new();

        if (simpleClass is null)
        {
            return _GRPC_BaseClass;
        }
        _GRPC_BaseClass = new()
        {
            Id = simpleClass.Id,
            ERPCode = simpleClass.ERPCode.HasValue ? simpleClass.ERPCode.Value : 0,
            SortIndex = simpleClass.SortIndex.HasValue ? simpleClass.SortIndex.Value : 0,
            EnableRecord = simpleClass.EnableRecord
        };

        return _GRPC_BaseClass;
    }
    public static GRPC_BaseClassWithName GetBaseClassWithName(this BaseEntity simpleClass)
    {
        GRPC_BaseClassWithName _GRPC_BaseClass = new();

        if (simpleClass is null)
        {
            return _GRPC_BaseClass;
        }
        _GRPC_BaseClass = new()
        {
            Id = simpleClass.Id,
            ERPCode = simpleClass.ERPCode,
            SortIndex = simpleClass.SortIndex,
            Name = simpleClass.Name,
            DisplayName = simpleClass.DisplayName,
            EnableRecord = simpleClass.EnableRecord
        };

        return _GRPC_BaseClass;
    }
    public static GRPC_BaseClassWithDate GetBaseClassWithDate(this BaseEntity simpleClass)
    {
        GRPC_BaseClassWithDate _GRPC_BaseClass = new();

        if (simpleClass is null)
        {
            return _GRPC_BaseClass;
        }
        _GRPC_BaseClass = new()
        {
            Id = simpleClass.Id,
            ERPCode = simpleClass.ERPCode,
            SortIndex = simpleClass.SortIndex,
            CreateTimeRecord = simpleClass.Created,
            LastUpdatedRecord = simpleClass.LastModified,
            EnableRecord = simpleClass.EnableRecord
        };

        return _GRPC_BaseClass;
    }
    public static GRPC_BaseClassWithNameAndDate GetBaseClassWithNameAndDate(this BaseEntity simpleClass)
    {
        GRPC_BaseClassWithNameAndDate _GRPC_BaseClass = new();

        if (simpleClass is null)
        {
            return _GRPC_BaseClass;
        }
        _GRPC_BaseClass = new()
        {
            Id = simpleClass.Id,
            ERPCode = simpleClass.ERPCode,
            SortIndex = simpleClass.SortIndex,
            Name = simpleClass.Name,
            DisplayName = simpleClass.DisplayName,
            CreateTimeRecord = simpleClass.Created,
            LastUpdatedRecord = simpleClass.LastModified,
            EnableRecord = simpleClass.EnableRecord
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

        _GRPC_BaseClass = new ()
        {
            Id = simpleClass.Id,
            ERPCode = simpleClass.ERPCode,
            SortIndex = simpleClass.SortIndex,
            EnableRecord = simpleClass.EnableRecord
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
            Id = simpleClass.Id,
            ERPCode = simpleClass.ERPCode,
            SortIndex = simpleClass.SortIndex,
            Name = simpleClass.Name,
            DisplayName = simpleClass.DisplayName,
            EnableRecord = simpleClass.EnableRecord
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
            Id = simpleClass.Id,
            ERPCode = simpleClass.ERPCode,
            SortIndex = simpleClass.SortIndex,
            Name = simpleClass.Name,
            DisplayName = simpleClass.DisplayName,
            CreateTimeRecord = simpleClass.Created,
            LastUpdatedRecord = simpleClass.LastModified,
            EnableRecord = simpleClass.EnableRecord
        };

        return _GRPC_BaseClass;
    }
    public static T GetSimpleClass<T>(this GRPC_BaseClassWithNameAndDate gRPC_BaseClass) where T : BaseEntity
    {
        if (gRPC_BaseClass is null)
        {
            return null;
        }

        var _SimpleClass = (T)Activator.CreateInstance(typeof(T));

        if (gRPC_BaseClass.Id is not null)
        {
            _SimpleClass.Id = gRPC_BaseClass.Id.Value;
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
            _SimpleClass.Created = gRPC_BaseClass.CreateTimeRecord;
        }
        if (gRPC_BaseClass.LastUpdatedRecord is not null)
        {
            _SimpleClass.LastModified = gRPC_BaseClass.LastUpdatedRecord;
        }
        if (gRPC_BaseClass.EnableRecord is not null)
        {
            _SimpleClass.EnableRecord = gRPC_BaseClass.EnableRecord.Value;
        }

        return _SimpleClass;
    }
    public static T GetSimpleClass<T>(this GRPC_BaseClassWithName gRPC_BaseClass) where T : BaseEntity
    {
        if (gRPC_BaseClass is null)
        {
            return null;
        }

        var _SimpleClass = (T)Activator.CreateInstance(typeof(T));

        if (gRPC_BaseClass.Id is not null)
        {
            _SimpleClass.Id = gRPC_BaseClass.Id.Value;
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
        if (gRPC_BaseClass.EnableRecord is not null)
        {
            _SimpleClass.EnableRecord = gRPC_BaseClass.EnableRecord.Value;
        }

        return _SimpleClass;
    }
    public static T GetSimpleClass<T>(this GRPC_BaseClass gRPC_BaseClass) where T : BaseEntity
    {
        if (gRPC_BaseClass is null)
        {
            return null;
        }

        var _SimpleClass = (T)Activator.CreateInstance(typeof(T));

        if (gRPC_BaseClass.Id is not null)
        {
            _SimpleClass.Id = gRPC_BaseClass.Id.Value;
        }
        if (gRPC_BaseClass.ERPCode is not null)
        {
            _SimpleClass.ERPCode = gRPC_BaseClass.ERPCode;
        }
        if (gRPC_BaseClass.SortIndex is not null)
        {
            _SimpleClass.SortIndex = gRPC_BaseClass.SortIndex;
        }
        if (gRPC_BaseClass.EnableRecord is not null)
        {
            _SimpleClass.EnableRecord = gRPC_BaseClass.EnableRecord.Value;
        }

        return _SimpleClass;
    }

    #region Condition method
    public static F_Condition GetCondition(this GRPC_Condition Condition)
    {
        F_Condition _condition = new();

        if (Condition.Base is not null)
        {
            _condition = new()
            {
                //Id = Condition.Base.Id.Value,
                Name = Condition.Base.Name,
                ERPCode = Condition.Base.ERPCode,
                SortIndex = Condition.Base.SortIndex,
                EnableRecord = (Condition.Base.EnableRecord is true)
            };
        }

        _condition.Tag = Condition?.Tag?.GetSimpleClass<D_Tag>();
        _condition.Operand = Condition?.Operand?.GetSimpleClass<D_Operand>();
        _condition.Value = Condition?.Value;
        return _condition;
    }
    public static IEnumerable<F_Condition> GetConditions(this IEnumerable<GRPC_Condition> Conditions)
    {
        foreach (var Condition in Conditions)
        {
            yield return GetCondition(Condition);
        }
    }
    public static IEnumerable<GRPC_Condition> GetConditions(this IEnumerable<F_Condition> f_conditions)
    {
        foreach (var f_condition in f_conditions)
        {
            GRPC_BaseClassWithName _conditionBase = new()
            {
                Id = f_condition?.Id,
                Name = f_condition?.Name,
                DisplayName = f_condition?.DisplayName,
                ERPCode = f_condition?.ERPCode,
                SortIndex = f_condition?.SortIndex
            };

            GRPC_Condition _condition = new()
            {
                Base = _conditionBase,
                Tag = f_condition?.Tag?.GetBaseClassWithName(),
                Operand = f_condition?.Operand?.GetBaseClassWithName(),
                Value = f_condition?.Value
            };

            yield return _condition;
        }
    }
    #endregion
}