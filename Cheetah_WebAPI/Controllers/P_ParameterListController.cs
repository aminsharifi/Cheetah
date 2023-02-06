using Cheetah_Business.Repository.IRepository;
using Cheetah_Models;
using Microsoft.AspNetCore.Mvc;

namespace Cheetah_WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class P_ParameterListController : ControllerBase
    {
        private readonly IP_ParameterListRepository _ParameterListRepository;
        public P_ParameterListController(IP_ParameterListRepository iP_ParameterListRepository)
        {
            this._ParameterListRepository = iP_ParameterListRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _ParameterListRepository.GetAll());
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

            var P_ParameterList = await _ParameterListRepository.Get(id.Value);

            if(P_ParameterList == null)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErorrMessage = "Invalid Id",
                    StatusCode = StatusCodes.Status404NotFound
                });
            }

            return Ok( P_ParameterList);
        }
    }
}
