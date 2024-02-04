using Cheetah.Domain.Entities.Facts;
using DNTPersianUtils.Core;

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
            Id = simpleClass.Id.HasValue ? simpleClass.Id.Value : 0,
            ERPCode = simpleClass.ERPCode.HasValue ? simpleClass.ERPCode.Value : 0,
            SortIndex = simpleClass.SortIndex.HasValue ? simpleClass.SortIndex.Value : 0
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
            DisplayName = simpleClass.DisplayName
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
            LastUpdatedRecord = simpleClass.LastModified
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
            LastUpdatedRecord = simpleClass.LastModified
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
            Id = simpleClass.Id,
            ERPCode = simpleClass.ERPCode,
            SortIndex = simpleClass.SortIndex
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
            DisplayName = simpleClass.DisplayName
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
            LastUpdatedRecord = simpleClass.LastModified
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
            _SimpleClass.Created = gRPC_BaseClass.CreateTimeRecord;
        }
        if (gRPC_BaseClass.LastUpdatedRecord is not null)
        {
            _SimpleClass.LastModified = gRPC_BaseClass.LastUpdatedRecord;
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
    public static T GetSimpleClass<T>(this GRPC_BaseClass gRPC_BaseClass) where T : BaseEntity
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
            f_Condition.Tag = Condition?.Tag?.GetSimpleClass<D_Tag>();
            f_Condition.Operand = Condition?.Operand?.GetSimpleClass<D_Operand>();
            f_Condition.Value = Condition?.Value;
            yield return f_Condition;
        }
    }
    public static IEnumerable<Condition> GetCondition(this IEnumerable<F_Condition> conditions)
    {
        foreach (var condition in conditions)
        {
            Condition _condition = new();
            _condition.Base = new()
            {
                Id = condition?.Id,
                Name = condition?.Name,
                ERPCode = condition?.ERPCode,
                SortIndex = condition?.SortIndex
            };
            _condition.Tag = condition?.Tag?.GetBaseClassWithName();
            _condition.Operand = condition?.Operand?.GetBaseClassWithName();
            _condition.Value = condition?.Value;
            yield return _condition;
        }
    }
}