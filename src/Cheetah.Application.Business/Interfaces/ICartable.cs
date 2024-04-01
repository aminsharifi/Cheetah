namespace Cheetah.Application.Business.Interfaces;
public interface ICartable
{
    public Task<Result<IEnumerable<CartableDTO>>> Inbox(CartableDTO cartableDTO);
    public Task<Result<IEnumerable<CartableDTO>>> Outbox(CartableDTO cartableDTO);
    public Task<Result<IEnumerable<F_Case>>> GetCaseAsync(F_Case request);
}
