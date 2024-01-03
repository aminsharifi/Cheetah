namespace Cheetah.Application.Business.Common.Models;

public class LookupDto
{
    public Int32 Id { get; init; }
    public String? Name { get; set; }
    public String? DisplayName { get; set; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<D_CaseState, LookupDto>();
        }
    }
}
