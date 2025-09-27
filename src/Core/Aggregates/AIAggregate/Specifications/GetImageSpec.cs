using Cheetah.Core.Aggregates.AIAggregate.Facts;
using System.Runtime.InteropServices;

namespace Cheetah.Core.Aggregates.CaseAggregate.Specifications;
public class GetImageSpec : SingleResultSpecification<F_UploadedFile>
{
    public GetImageSpec(String FileName)
    {
        Query
            .Where(x => x.Name == FileName);

        Query
            .AsNoTracking();
    }
}