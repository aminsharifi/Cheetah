using Cheetah.Infrastructure.Data;

namespace Cheetah.Sample.Presentation.Services.GraphQL;

public class Query
{
    public IQueryable<string> ListString([Service] ApplicationDbContext context)
    {
        List<string> ListString = new List<string>();
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