using Ardalis.SharedKernel;
using Cheetah.Core.Aggregates.ConditionAggregate.DTOs;
using Cheetah.Core.Common.DTOs;
using Cheetah.Core.Common.Specifications;
using Cheetah.Core.Entities.Dimentions;
using Cheetah.Core.Entities.Facts;
using Cheetah.UseCases.Queries.Condition.Get;
using Mapster;
using NSubstitute;

namespace Cheetah.UnitTest.UseCases.Queries.Condition.Get;

public class GetConditionIdHandlerHandle
{
    IReadRepository<F_Condition> _conditionRepository;
    IReadRepository<D_Tag> _tagRepository;
    IReadRepository<D_Operand> _operandRepository;
    ConditionDTO _input;
    GetConditionIdQuery _request;
    F_Condition _condition;
    D_Tag _tag;
    D_Operand _operand;
    public GetConditionIdHandlerHandle()
    {
        _conditionRepository = Substitute.For<IReadRepository<F_Condition>>();
        _tagRepository = Substitute.For<IReadRepository<D_Tag>>();
        _operandRepository = Substitute.For<IReadRepository<D_Operand>>();

        _condition = F_Condition.Approve;
        _tag = D_Tag.ReviewState;
        _operand = D_Operand.Equals;

        _conditionRepository
            .FirstOrDefaultAsync(Arg.Any<GetIdEntitySpec<F_Condition>>(), CancellationToken.None)
            .Returns(_condition.Id);

        _tagRepository
            .FirstOrDefaultAsync(Arg.Any<GetIdEntitySpec<D_Tag>>(), CancellationToken.None)
            .Returns(_tag.Id);

        _operandRepository
            .FirstOrDefaultAsync(Arg.Any<GetIdEntitySpec<D_Operand>>())
            .Returns(_operand.Id);

        _input = new ConditionDTO() { Base = _condition.Adapt<BaseClassWithNameDTO>() };
    }
    [Fact]
    public async Task GetConditionId()
    {
        #region Arrange
        _request = new GetConditionIdQuery(_input);
        GetConditionIdHandler _getConditionIdHandler = new GetConditionIdHandler
            (conditionRepository: _conditionRepository, tagRepository: _tagRepository,
            operandRepository: _operandRepository);

        #endregion

        #region Act
        var _result = await _getConditionIdHandler.Handle(_request, CancellationToken.None);
        #endregion

        #region Assert
        Assert.Equal(_condition.Id, _result.Value);
        #endregion
    }
}
