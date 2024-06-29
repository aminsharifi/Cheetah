namespace Cheetah.Presentation.Services.WebAPI.Helper;

public static class APIConverter
{
    public static BaseClassWithNameDTO GetBaseClassWithName(this SimpleClassDTO simpleClass, IMapper mapper)
    {
        BaseClassWithNameDTO _GRPC_BaseClass = mapper.Map<BaseClassWithNameDTO>(simpleClass);

        return _GRPC_BaseClass;
    }
    public static BaseClassWithNameAndDateDTO GetBaseClassWithNameAndDate(this SimpleClassDTO simpleClass, IMapper mapper)
    {
        BaseClassWithNameAndDateDTO _GRPC_BaseClass = mapper.Map<BaseClassWithNameAndDateDTO>(simpleClass);

        return _GRPC_BaseClass;
    }
 
    public static T GetSimpleClass<T>(this BaseClassWithNameDTO gRPC_BaseClass, IMapper mapper) where T : BaseEntity
    {
        T _GRPC_BaseClass = mapper.Map<T>(gRPC_BaseClass);

        return _GRPC_BaseClass;
    }

    #region Condition method
    public static F_Condition GetCondition(this ConditionDTO Condition, IMapper mapper)
    {
        F_Condition _condition = Condition.Base is null ? new() : mapper.Map<F_Condition>(Condition.Base);
        var _tag = Condition?.Tag?.Adapt<D_Tag>();
        var _operand = Condition?.Operand?.Adapt<D_Operand>();
        var _value = Condition?.Value;

        _condition.SetConditionValue(tag: _tag, operand: _operand, value: _value);

        return _condition;
    }
  
    public static IEnumerable<ConditionDTO> GetConditions(this IEnumerable<F_Condition> f_conditions)
    {
        foreach (var f_condition in f_conditions)
        {
            ConditionDTO _condition = new()
            {
                Base = f_condition.Adapt<BaseClassWithNameDTO>(),
                Tag = f_condition?.Tag?.Adapt<BaseClassWithNameDTO>(),
                Operand = f_condition?.Operand?.Adapt<BaseClassWithNameDTO>(),
                Value = f_condition?.Value
            };

            yield return _condition;
        }
    }
    #endregion
}