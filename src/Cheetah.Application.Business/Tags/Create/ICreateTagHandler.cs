using Ardalis.Result;

namespace Cheetah.Application.Business.Tags.Create
{
    public interface ICreateTagHandler
    {
        Task<Result<long>> Handle(CreateTagCommand request, CancellationToken cancellationToken);
    }
}