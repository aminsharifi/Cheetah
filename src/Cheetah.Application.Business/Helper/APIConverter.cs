using MapsterMapper;

namespace Cheetah.Presentation.Services.WebAPI.Helper;

public static class APIConverter
{
    public static GRPC_BaseClass GetBaseClass(this BaseEntity simpleClass, IMapper mapper)
    {
        GRPC_BaseClass _GRPC_BaseClass = mapper.Map<GRPC_BaseClass>(simpleClass);

        return _GRPC_BaseClass;
    }
    public static GRPC_BaseClassWithName GetBaseClassWithName(this BaseEntity simpleClass, IMapper mapper)
    {
        GRPC_BaseClassWithName _GRPC_BaseClass = mapper.Map<GRPC_BaseClassWithName>(simpleClass);

        return _GRPC_BaseClass;
    }
    public static GRPC_BaseClassWithDate GetBaseClassWithDate(this BaseEntity simpleClass, IMapper mapper)
    {
        GRPC_BaseClassWithDate _GRPC_BaseClass = mapper.Map<GRPC_BaseClassWithDate>(simpleClass);

        return _GRPC_BaseClass;
    }
    public static GRPC_BaseClassWithNameAndDate GetBaseClassWithNameAndDate(this BaseEntity simpleClass, IMapper mapper)
    {
        GRPC_BaseClassWithNameAndDate _GRPC_BaseClass = mapper.Map<GRPC_BaseClassWithNameAndDate>(simpleClass);

        return _GRPC_BaseClass;
    }

    public static GRPC_BaseClass GetBaseClass(this SimpleClassDTO simpleClass, IMapper mapper)
    {
        GRPC_BaseClass _GRPC_BaseClass = mapper.Map<GRPC_BaseClass>(simpleClass);

        return _GRPC_BaseClass;
    }
    public static GRPC_BaseClassWithName GetBaseClassWithName(this SimpleClassDTO simpleClass, IMapper mapper)
    {
        GRPC_BaseClassWithName _GRPC_BaseClass = mapper.Map<GRPC_BaseClassWithName>(simpleClass);

        return _GRPC_BaseClass;
    }
    public static GRPC_BaseClassWithNameAndDate GetBaseClassWithNameAndDate(this SimpleClassDTO simpleClass, IMapper mapper)
    {
        GRPC_BaseClassWithNameAndDate _GRPC_BaseClass = mapper.Map<GRPC_BaseClassWithNameAndDate>(simpleClass);

        return _GRPC_BaseClass;
    }
    public static T GetSimpleClass<T>(this GRPC_BaseClassWithNameAndDate gRPC_BaseClass, IMapper mapper) where T : BaseEntity
    {
        T _GRPC_BaseClass = mapper.Map<T>(gRPC_BaseClass);

        return _GRPC_BaseClass;
    }
    public static T GetSimpleClass<T>(this GRPC_BaseClassWithName gRPC_BaseClass, IMapper mapper) where T : BaseEntity
    {
        T _GRPC_BaseClass = mapper.Map<T>(gRPC_BaseClass);

        return _GRPC_BaseClass;
    }
    public static T GetSimpleClass<T>(this GRPC_BaseClass gRPC_BaseClass, IMapper mapper) where T : BaseEntity
    {
        T _GRPC_BaseClass = mapper.Map<T>(gRPC_BaseClass);

        return _GRPC_BaseClass;
    }

    #region Condition method
    public static F_Condition GetCondition(this GRPC_Condition Condition, IMapper mapper)
    {
        F_Condition _condition = Condition.Base is null ? new() : mapper.Map<F_Condition>(Condition.Base);
        _condition.Tag = Condition?.Tag?.GetSimpleClass<D_Tag>(mapper);
        _condition.Operand = Condition?.Operand?.GetSimpleClass<D_Operand>(mapper);
        _condition.Value = Condition?.Value;
        return _condition;
    }
    public static IEnumerable<F_Condition> GetConditions(this IEnumerable<GRPC_Condition> Conditions, IMapper mapper)
    {
        foreach (var Condition in Conditions)
        {
            yield return GetCondition(Condition, mapper);
        }
    }
    public static IEnumerable<GRPC_Condition> GetConditions(this IEnumerable<F_Condition> f_conditions, IMapper mapper)
    {
        foreach (var f_condition in f_conditions)
        {

            GRPC_BaseClassWithName _conditionBase = mapper.Map<GRPC_BaseClassWithName>(f_condition);

            GRPC_Condition _condition = new()
            {
                Base = _conditionBase,
                Tag = f_condition?.Tag?.GetBaseClassWithName(mapper),
                Operand = f_condition?.Operand?.GetBaseClassWithName(mapper),
                Value = f_condition?.Value
            };

            yield return _condition;
        }
    }
    #endregion
}