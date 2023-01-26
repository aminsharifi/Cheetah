using AutoMapper;
using Cheetah_Models;
using Cheetah_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheetah_Business.Mapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
               CreateMap<CopyROLE, CopyROLEDTO>().ReverseMap();
        }
    }
}
