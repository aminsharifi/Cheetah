using Cheetah.Core.Common.DTOs;
using Cheetah.Core.DTOs.Entity;
using Cheetah.Core.Interfaces;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.EntityManager.Queries;

public class GetAllByName(ILogger<GetAllByName> logger, ITableCRUD simpleClassRepository)
    : Endpoint<GetAllByNameRequest, GetAllByNameResponse>
{
    public override void Configure()
    {
        Post(GetAllByNameRequest.Route);
        AllowAnonymous();
    }
    public override async Task HandleAsync(GetAllByNameRequest request, CancellationToken cancellationToken)
    {
        logger.LogInformation("started " + nameof(GetAllByName) + " {@" + nameof(GetAllByName) + "}", request);

        #region Input

        GetAllByName_Response output_Request = new();

        if (string.IsNullOrWhiteSpace(request.TableInput.Name))
        {
            Response = output_Request.Adapt<GetAllByNameResponse>();

            return;
        }

        output_Request.TableInput = request.TableInput;

        #endregion

        var TableRecords = await simpleClassRepository
            .GetAllBySimpleClassAsync(
            output_Request.TableInput.Adapt<SimpleClassDTO>());

        #region Output

        output_Request.TableInput = TableRecords.Item1.Adapt<BaseClassWithNameDTO>();

        output_Request.TableOutput
            .AddRange(TableRecords.Item2
            .Select(x => x.Adapt<BaseClassWithNameDTO>()));

        output_Request.OutputState = new BaseClassWithNameDTO() { Id = 0 };

        #endregion

        logger.LogInformation("Ended " + nameof(GetAllByName) + " {@" + nameof(GetAllByName) + "}", output_Request);

        Response = output_Request.Adapt<GetAllByNameResponse>();

        return;
    }
}