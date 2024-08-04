using Ardalis.SharedKernel;
using Cheetah.Core.Aggregates.ConditionAggregate.Specifications;
using Cheetah.Core.Common.Specifications;
using Cheetah.Core.Entities.Dimentions;
using Cheetah.Core.Entities.Facts;
using Cheetah.UseCases.Queries.Condition.Get;
using NSubstitute;

namespace Cheetah.UnitTest.UseCases.Queries.Condition.Get;

public class GetConditionExistsHandlerHandle
{
    IReadRepository<F_Condition> _conditionRepository;
    IReadRepository<D_Tag> _tagRepository;
    IReadRepository<D_Operand> _operandRepository;
    D_Tag _tag;
    D_Operand _operand;
    F_Condition _condition;
    GetConditionExistsQuery _request;
    public GetConditionExistsHandlerHandle()
    {
        _conditionRepository = Substitute.For<IReadRepository<F_Condition>>();
        _tagRepository = Substitute.For<IReadRepository<D_Tag>>();
        _operandRepository = Substitute.For<IReadRepository<D_Operand>>();

        _tag = D_Tag.ReviewState;
        _tagRepository
            .FirstOrDefaultAsync(Arg.Any<GetIdEntitySpec<D_Tag>>(), CancellationToken.None)
            .Returns(_tag.Id);

        _operand = D_Operand.Equals;
        _operandRepository
            .FirstOrDefaultAsync(Arg.Any<GetIdEntitySpec<D_Operand>>(), CancellationToken.None)
            .Returns(_operand.Id);

        _condition = new();
        _condition.SetTag(_tag);
        _condition.SetOperand(_operand);

        _request = new GetConditionExistsQuery(_condition);
    }

    [Fact]
    public async void CheckConditionExist()
    {
        #region Arrange
        _condition = new F_Condition()
            .SetTagId(_tag.Id)
            .SetOperandId(_operand.Id);

        _conditionRepository
            .AnyAsync(Arg.Any<GetConditionIdSpec>(), CancellationToken.None)
            .Returns(true);
        #endregion

        #region Act
        GetConditionExistsHandler _getConditionExistsHandler =
            new(conditionRepository: _conditionRepository,
            tagRepository: _tagRepository,
            operandRepository: _operandRepository);
        var _result = await _getConditionExistsHandler.Handle(_request, CancellationToken.None);
        #endregion

        #region Assert
        Assert.True(_result.Value);
        #endregion
    }

}
