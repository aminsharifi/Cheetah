using Cheetah.Core.Enums;
using Cheetah.Core.Interfaces.Cartable.DTOs;

namespace Cheetah.Core.Interfaces.Cartable;
public interface ICartable
{
    public Task<Result<IEnumerable<CartableDTO>>> GetCartableAsync(CartableDTO cartableDTO);
    public Task<Result<IEnumerable<CartableDTO>>> InboxAsync(CartableDTO cartableDTO);
    public Task<Result<IEnumerable<CartableDTO>>> OutboxAsync(CartableDTO cartableDTO);
    public Task<Result<CartableResponse>> GetCartableAsync(CartableRequest request, CartableProperty? cartableProperty);
    public Task<Result<CartableResponse>> InboxAsync(CartableRequest request);
    public Task<Result<CartableResponse>> OutboxAsync(CartableRequest request);
}
