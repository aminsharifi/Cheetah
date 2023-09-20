namespace Cheetah_Business.Repository
{
    public interface IView
    {
        public Task<Boolean> createViews();
        public Task<Boolean> RemoveView(string ViewName);
    }
}
