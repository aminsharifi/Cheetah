using Cheetah_Business.Data;
using Cheetah_Business.Facts;

namespace Cheetah_Business.Repository
{
    public interface ICartable
    {
        public Task<List<CartableDTO>> Inbox(CartableDTO cartableDTO);
        public Task<List<CartableDTO>> Outbox(CartableDTO cartableDTO);        
        public Task<IQueryable<F_Case>> GetCaseAsync(F_Case request);
    }
}
