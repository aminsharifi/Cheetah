using AutoMapper;
using Cheetah_Business;
using Cheetah_Business.Data;
using Cheetah_Business.Facts;
using Cheetah_Business.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Cheetah_WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class F_ConditionController : ControllerBase
    {
        private readonly ISimpleClassRepository simpleClassRepository;
        private readonly IMapper _mapper;
        public F_ConditionController(ISimpleClassRepository iP_ParameterListRepository, IMapper mapper)
        {
            this._mapper = mapper;
            this.simpleClassRepository = iP_ParameterListRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var D_ParameterList = await simpleClassRepository.GetAllByName(nameof(F_Condition)) as IEnumerable<SimpleClass>;
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

            var _Record = await simpleClassRepository.Get(nameof(F_Condition), id.Value);

            if (_Record == null)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErorrMessage = "Invalid Id",
                    StatusCode = StatusCodes.Status404NotFound
                });
            }

            return Ok(_Record);
        }
    }
}
