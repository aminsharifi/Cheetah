using AutoMapper;
using Cheetah_DataAccess.Dimentions;
using Cheetah_DataAccess.Parameters;

namespace Cheetah_Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<D_ParameterList, D_ParameterList>().ReverseMap();
            CreateMap<D_ParameterType, D_ParameterType>().ReverseMap();
            CreateMap<D_Position, D_Position>().ReverseMap();
            CreateMap<D_ProcessEndorsement, D_ProcessEndorsement>().ReverseMap();
            CreateMap<D_ProcessState, D_ProcessState>().ReverseMap();
            CreateMap<D_RequestTitle, D_RequestTitle>().ReverseMap();
            CreateMap<D_SubRequestTitle, D_SubRequestTitle>().ReverseMap();
        }
    }
}
