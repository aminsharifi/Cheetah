namespace Cheetah.Application.Business.Interfaces;
public interface ICartable
{
    public Task<Result<IEnumerable<CartableDTO>>> GetCartableAsync(CartableDTO cartableDTO);
    public Task<Result<IEnumerable<CartableDTO>>> InboxAsync(CartableDTO cartableDTO);
    public Task<Result<IEnumerable<CartableDTO>>> OutboxAsync(CartableDTO cartableDTO);
    public Task<Result<Cartable_Response>> GetCartableAsync(Cartable_Request request, CartableProperty? cartableProperty);
    public Task<Result<Cartable_Response>> InboxAsync(Cartable_Request request);
    public Task<Result<Cartable_Response>> OutboxAsync(Cartable_Request request);
}
