using Cheetah_Business.Repository.IRepository;
using Cheetah_DataAccess.Parameters;
using Cheetah_Models;
using Microsoft.AspNetCore.Mvc;

namespace Cheetah_WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class P_ParameterListController : ControllerBase
    {
        private readonly IGeneralRepository<D_ParameterList> _ParameterListRepository;
        public P_ParameterListController(IGeneralRepository<D_ParameterList> iP_ParameterListRepository)
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
