namespace Cheetah.Application.Business.Tags.Get;


public record GetOperandIdQuery(D_Operand input) : IQuery<Result<long>>;
