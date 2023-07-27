using Cheetah_Business.Facts;

namespace Cheetah_Business.Repository
{
    public interface ICopyClass
    {
        public Task<F_Case> DeepCopy(F_Case obj);
    }
}
