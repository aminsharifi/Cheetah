using Cheetah_Business.Repository.IRepository;
using Cheetah_Business.Repository.IRepository.General;
using Cheetah_Models;
using Cheetah_Models.Masters;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Cheetah_WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class P_ProcessController : ControllerBase
    {

        private readonly IProcessRepository _IProcessRepository;
        public P_ProcessController(IProcessRepository iProcessRepository)
        {
            this._IProcessRepository = iProcessRepository;
        }
        
        /*
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProcess(long? id)
        {
            if (id == null)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErorrMessage = "Invalid Id",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }

            var process = await _IProcessRepository.GetProcess(id.Value);

            if (process == null)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErorrMessage = "Invalid Id",
                    StatusCode = StatusCodes.Status404NotFound
                });
            }

            return Ok(process);
        }
        */

        [HttpGet("{jsonInput}")]
        public async Task<IActionResult> CreateProcess(String? jsonInput)
        {
            if (jsonInput == null)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErorrMessage = "Invalid JSON",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }

            var P_ParameterList = await _IProcessRepository.CreateProcess(jsonInput);

            if(P_ParameterList == null)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErorrMessage = "Invalid JSON",
                    StatusCode = StatusCodes.Status404NotFound
                });
            }

            return Ok(P_ParameterList);
        }        
    }
}
