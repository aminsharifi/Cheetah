using Cheetah.Domain.Enums;

namespace Cheetah.Application.Business.WorkItem.Get;

public record GetCartableQuery(CartableDTO cartableDTO, CartableProperty cartableProperty) : IQuery<Result<IEnumerable<CartableDTO>>>;