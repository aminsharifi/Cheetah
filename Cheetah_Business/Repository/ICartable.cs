using Cheetah_Business.Data;
using Cheetah_Business.Facts;

namespace Cheetah_Business.Repository
{
    public interface ICartable
    {
        public Task<IQueryable<CartableDTO>> Inbox(CartableDTO cartableDTO);
        public Task<IQueryable<CartableDTO>> Outbox(CartableDTO cartableDTO);
        public Task<F_Case> GetCaseAsync(F_Case request);
    }
}
