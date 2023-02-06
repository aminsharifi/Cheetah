using AutoMapper;
using Cheetah_Models;
using Cheetah_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cheetah_Models.Parameters;
using Cheetah_DataAccess.Parameters;

namespace Cheetah_Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CopyROLE, CopyROLEDTO>().ReverseMap();
            CreateMap<P_ParameterList, P_ParameterListDTO>().ReverseMap();
            CreateMap<P_ParameterType, P_ParameterListDTO>().ReverseMap();
            CreateMap<P_PositionOrg, P_PositionOrgDTO>().ReverseMap();
            CreateMap<P_ProcessEndorsement, P_ProcessEndorsementDTO>().ReverseMap();
            CreateMap<P_ProcessState, P_ProcessStateDTO>().ReverseMap();
            CreateMap<P_RequestTitle, P_RequestTitleDTO>().ReverseMap();
            CreateMap<P_RequestType, P_RequestTypeDTO>().ReverseMap();
            CreateMap<P_SubRequestTitle, P_SubRequestTitleDTO>().ReverseMap();
            CreateMap<P_UserAction, P_UserActionDTO>().ReverseMap();
            CreateMap<P_UserActionGroup, P_UserActionGroupDTO>().ReverseMap();
        }
    }
}
