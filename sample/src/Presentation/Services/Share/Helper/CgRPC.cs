using Cheetah.Core.Common;
using Cheetah.Core.Common.DTOs;
using Cheetah.Core.Entities.Dimentions;
using Cheetah.Core.Entities.Facts;
using Cheetah_GrpcService;

namespace Cheetah.Sample.Presentation.Services.Share.Helper;

public static class CgRPC
{
    public static Timestamp CGetTimestamp(this DateTimeOffset? dateTime)
    {
        if (!dateTime.HasValue)
        {
            return null!;
        }
        return dateTime.Value.ToTimestamp();
    }
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
            ERPCode = simpleClass.ERPCode.HasValue ? simpleClass.ERPCode.Value : 0,
            SortIndex = simpleClass.SortIndex.HasValue ? simpleClass.SortIndex.Value : 0,
            Name = simpleClass.Name is not null ? simpleClass.Name : string.Empty,
            DisplayName = simpleClass.DisplayName is not null ? simpleClass.DisplayName : string.Empty,
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
            ERPCode = simpleClass.ERPCode.HasValue ? simpleClass.ERPCode.Value : 0,
            SortIndex = simpleClass.SortIndex.HasValue ? simpleClass.SortIndex.Value : 0,
            CreateTimeRecord = simpleClass.Created.CGetTimestamp(),
            LastUpdatedRecord = simpleClass.LastModified.CGetTimestamp(),
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
            ERPCode = simpleClass.ERPCode.HasValue ? simpleClass.ERPCode.Value : 0,
            SortIndex = simpleClass.SortIndex.HasValue ? simpleClass.SortIndex.Value : 0,
            Name = simpleClass.Name is not null ? simpleClass.Name : string.Empty,
            DisplayName = simpleClass.DisplayName is not null ? simpleClass.DisplayName : string.Empty,
            EnableRecord = simpleClass.EnableRecord
        };

        return _GRPC_BaseClass;
    }

    #region Condition method
    public static F_Condition GetCondition(this GRPC_Condition Condition)
    {
        F_Condition _condition = new();

        if (Condition.Base is not null)
        {
            _condition = new();

            _condition
                .SetName(Condition.Base.Name)
                .SetERPCode(Condition.Base.ERPCode)
                .SetSortIndex(Condition.Base.SortIndex)
                .SetEnableRecord(Condition?.Base?.EnableRecord is true);
        }

        _condition.SetConditionValue(tag: Condition?.Tag?.GetSimpleClass<D_Tag>(),
            operand: Condition?.Operand?.GetSimpleClass<D_Operand>(), value: Condition?.Value);

        return _condition;
    }
    public static IEnumerable<F_Condition> GetConditions(this IEnumerable<GRPC_Condition> Conditions)
    {
        foreach (var Condition in Conditions)
        {
            yield return Condition.GetCondition();
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

    #region Convert to the Cheetah class
    public static T GetSimpleClass<T>(this GRPC_BaseClassWithNameAndDate gRPC_BaseClass) where T : BaseEntity
    {
        if (gRPC_BaseClass is null)
        {
            return null!;
        }

        var _SimpleClass = (T)Activator.CreateInstance(typeof(T))!;

        if (gRPC_BaseClass.Id is not null)
        {
            _SimpleClass.Id = gRPC_BaseClass.Id.Value;
        }

        _SimpleClass
            .SetName(gRPC_BaseClass.Name)
            .SetDisplayName(gRPC_BaseClass.DisplayName)
            .SetEnableRecord(gRPC_BaseClass.EnableRecord is true)
            .SetERPCode(gRPC_BaseClass.ERPCode)
            .SetSortIndex(gRPC_BaseClass.SortIndex)
            .SetCreated(gRPC_BaseClass.CreateTimeRecord?.ToDateTimeOffset())
            .SetLastModified(gRPC_BaseClass.LastUpdatedRecord?.ToDateTimeOffset());

        return _SimpleClass;
    }
    public static T GetSimpleClass<T>(this GRPC_BaseClassWithDate gRPC_BaseClass) where T : BaseEntity
    {
        var _SimpleClass = (T)Activator.CreateInstance(typeof(T))!;

        if (gRPC_BaseClass is null)
        {
            return _SimpleClass!;
        }

        if (gRPC_BaseClass.Id is not null)
        {
            _SimpleClass!.Id = gRPC_BaseClass.Id.Value;
        }

        _SimpleClass?
            .SetEnableRecord(gRPC_BaseClass.EnableRecord is true)
            .SetERPCode(gRPC_BaseClass.ERPCode)
            .SetSortIndex(gRPC_BaseClass.SortIndex)
            .SetCreated(gRPC_BaseClass.CreateTimeRecord?.ToDateTimeOffset())
            .SetLastModified(gRPC_BaseClass.LastUpdatedRecord?.ToDateTimeOffset());

        return _SimpleClass!;
    }
    public static T GetSimpleClass<T>(this GRPC_BaseClassWithName gRPC_BaseClass) where T : BaseEntity
    {
        var _SimpleClass = (T)Activator.CreateInstance(typeof(T))!;

        if (gRPC_BaseClass is null)
        {
            return _SimpleClass;
        }

        if (gRPC_BaseClass.Id is not null)
        {
            _SimpleClass!.Id = gRPC_BaseClass.Id.Value;
        }

        _SimpleClass?
            .SetERPCode(gRPC_BaseClass.ERPCode)
            .SetSortIndex(gRPC_BaseClass.SortIndex)
            .SetName(gRPC_BaseClass.Name)
            .SetDisplayName(gRPC_BaseClass.DisplayName)
            .SetEnableRecord(gRPC_BaseClass.EnableRecord is true);

        return _SimpleClass!;
    }
    public static T GetSimpleClass<T>(this GRPC_BaseClass gRPC_BaseClass) where T : BaseEntity
    {
        var _SimpleClass = (T)Activator.CreateInstance(typeof(T))!;

        if (gRPC_BaseClass is null)
        {
            return _SimpleClass!;
        }

        if (gRPC_BaseClass.Id is not null)
        {
            _SimpleClass!.Id = gRPC_BaseClass.Id.Value;
        }

        _SimpleClass?
            .SetERPCode(gRPC_BaseClass.ERPCode)
            .SetSortIndex(gRPC_BaseClass.SortIndex)
            .SetEnableRecord(gRPC_BaseClass.EnableRecord is true);

        return _SimpleClass!;
    }
    #endregion
}
