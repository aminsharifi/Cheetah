namespace Cheetah.Application.Business.Repository;
public interface IView
{
    public Task<Boolean> createViews();
    public Task<Boolean> RemoveView(string ViewName);
}