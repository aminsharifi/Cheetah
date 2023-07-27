using Cheetah_Business.Data;
using Cheetah_Business.Facts;

namespace Cheetah_Business.Repository
{
    public interface ICartable
    {
        public Task<IEnumerable<CartableDTO>> Inbox(CartableDTO cartableDTO);
        public Task<IEnumerable<CartableDTO>> Outbox(CartableDTO cartableDTO);
        public Task<F_Case> GetCaseAsync(F_Case request);
    }
}
