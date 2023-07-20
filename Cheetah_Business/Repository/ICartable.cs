using Cheetah_Business.Data;

namespace Cheetah_Business.Repository
{
    public interface ICartable
    {
        public Task<IEnumerable<CartableDTO>> Inbox(CartableDTO cartableDTO);
        public Task<IEnumerable<CartableDTO>> Outbox(CartableDTO cartableDTO);
    }
}
