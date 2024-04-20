namespace Cheetah.Application.Business.Operand.Get;


public record GetOperandIdQuery(D_Operand input) : IQuery<Result<long>>;
