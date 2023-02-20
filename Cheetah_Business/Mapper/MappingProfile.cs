using AutoMapper;
using Cheetah_DataAccess.Parameters;

namespace Cheetah_Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<P_ParameterList, P_ParameterList>().ReverseMap();
            CreateMap<P_ParameterType, P_ParameterType>().ReverseMap();
            CreateMap<P_PositionOrg, P_PositionOrg>().ReverseMap();
            CreateMap<P_ProcessEndorsement, P_ProcessEndorsement>().ReverseMap();
            CreateMap<P_ProcessState, P_ProcessState>().ReverseMap();
            CreateMap<P_RequestTitle, P_RequestTitle>().ReverseMap();
            CreateMap<P_RequestType, P_RequestType>().ReverseMap();
            CreateMap<P_SubRequestTitle, P_SubRequestTitle>().ReverseMap();
        }
    }
}
