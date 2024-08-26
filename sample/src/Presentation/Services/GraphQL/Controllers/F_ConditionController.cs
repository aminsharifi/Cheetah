using Cheetah.Core.Aggregates.ConditionAggregate.Facts;
using Cheetah.Core.Common;
using Cheetah.Core.Common.DTOs;
using Cheetah.Core.Interfaces;

namespace Cheetah.Sample.Presentation.Services.GraphQL.Controllers;
[Route("[controller]")]
[ApiController]
public class F_ConditionController : ControllerBase
{
    private readonly ITableCRUD simpleClassRepository;
    public F_ConditionController(ITableCRUD iP_ParameterListRepository)
    {
        simpleClassRepository = iP_ParameterListRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var D_ParameterList = await simpleClassRepository.GetAllByNameAsync(nameof(F_Condition)) as IEnumerable<BaseEntity>;
        var simpleClassDTO = new List<SimpleClassDTO>();
        foreach (var SimpleClassDTO in D_ParameterList)
        {
            simpleClassDTO.Add(new SimpleClassDTO()
            {
                Id = SimpleClassDTO.Id,
                Name = SimpleClassDTO.Name,
                DisplayName = SimpleClassDTO.DisplayName,
                SortIndex = SimpleClassDTO.SortIndex,
                ERPCode = SimpleClassDTO.ERPCode
            });
        }
        return Ok(simpleClassDTO);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(long? id)
    {
        if (id == null || id == 0)
        {
            //return BadRequest(new CheetahResult()
            //{
            //    //ErorrMessage = "Invalid Id",
            //    //StatusCode = StatusCodes.Status400BadRequest

            //});
        }

        var _Record = await simpleClassRepository.GetAsync(nameof(F_Condition), id.Value);

        if (_Record == null)
        {
            //return BadRequest(new CheetahResult()
            //{
            //    //ErorrMessage = "Invalid Id",
            //    //StatusCode = StatusCodes.Status404NotFound
            //});
        }

        return Ok(_Record);
    }
}

