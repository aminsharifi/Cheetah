namespace Cheetah.Application.Services.Controllers;
[Route("[controller]")]
[ApiController]
public class F_ConditionController : ControllerBase
{
    private readonly ITableCRUD simpleClassRepository;
    public F_ConditionController(ITableCRUD iP_ParameterListRepository)
    {
        this.simpleClassRepository = iP_ParameterListRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var D_ParameterList = await simpleClassRepository.GetAllByName(nameof(F_Condition)) as IEnumerable<BaseEntity>;
        var simpleClassDTO = new List<SimpleClassDTO>();
        foreach (var SimpleClassDTO in D_ParameterList)
        {
            simpleClassDTO.Add(new SimpleClassDTO()
            {
                Id = SimpleClassDTO.Id,
                Name = SimpleClassDTO.Name,
                Description = SimpleClassDTO.Description
            });
        }
        return Ok(simpleClassDTO);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(long? id)
    {
        if (id == null || id == 0)
        {
            return BadRequest(new CheetahResult()
            {
                //ErorrMessage = "Invalid Id",
                //StatusCode = StatusCodes.Status400BadRequest
                
            });
        }

        var _Record = await simpleClassRepository.Get(nameof(F_Condition), id.Value);

        if (_Record == null)
        {
            return BadRequest(new CheetahResult()
            {
                //ErorrMessage = "Invalid Id",
                //StatusCode = StatusCodes.Status404NotFound
            });
        }

        return Ok(_Record);
    }
}

