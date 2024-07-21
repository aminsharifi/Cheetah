using Cheetah.Infrastructure.Persistence.Data;

namespace Cheetah.Presentation.Services.GraphQL;

public class Query
{
    public IQueryable<String> ListString([Service] ApplicationDbContext context)
    {
        List<String> ListString = new List<String>();
        ListString.Add("1");
        ListString.Add("2");
        ListString.Add("3");
        return ListString.AsQueryable();
    }
    //public IQueryable<D_Tag> d_Tags([Service] ApplicationDbContext context)
    //{
    //    return context.D_Tags;
    //}
}