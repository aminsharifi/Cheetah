namespace Cheetah.Domain.Interfaces;

public interface ICReadRepository<T>: IReadRepository<T> where T : class, IAggregateRoot
{
}