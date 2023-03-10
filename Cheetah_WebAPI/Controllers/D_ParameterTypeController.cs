using AutoMapper;
using Cheetah_Business.Repository.IRepository;
using Cheetah_DataAccess.Data;
using Cheetah_Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace Cheetah_WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class D_ParameterTypeController : ControllerBase
    {
        private readonly ISimpleClassRepository simpleClassRepository;
        private readonly IMapper _mapper;
        public D_ParameterTypeController(ISimpleClassRepository iP_ParameterListRepository, IMapper mapper)
        {
            this._mapper = mapper;
            this.simpleClassRepository = iP_ParameterListRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var D_ParameterList = await simpleClassRepository.GetAllByName("D_ParameterList") as IEnumerable<SimpleClass>;
            var simpleClassDTO = new List<SimpleClassDTO>();
            foreach (var SimpleClassDTO in D_ParameterList)
            {
                simpleClassDTO.Add(new SimpleClassDTO()
                {
                    Id = SimpleClassDTO.Id,
                    PName = SimpleClassDTO.PName,
                    PDescription = SimpleClassDTO.PDescription
                });
            }
            return Ok(simpleClassDTO);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long? id)
        {
            if (id == null || id == 0)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErorrMessage = "Invalid Id",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }

            var P_ParameterList = await simpleClassRepository.Get("P_ParameterList", id.Value);

            if (P_ParameterList == null)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErorrMessage = "Invalid Id",
                    StatusCode = StatusCodes.Status404NotFound
                });
            }

            return Ok(P_ParameterList);
        }
    }
}
