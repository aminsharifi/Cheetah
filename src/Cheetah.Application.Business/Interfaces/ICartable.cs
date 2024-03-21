namespace Cheetah.Application.Business.Interfaces;
public interface ICartable
{
    public Task<List<CartableDTO>> Inbox(CartableDTO cartableDTO);
    public Task<List<CartableDTO>> Outbox(CartableDTO cartableDTO);
    public Task<List<F_Case>> GetCaseAsync(F_Case request);
}
