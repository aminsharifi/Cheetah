using Ardalis.SharedKernel;
using Cheetah.Core.Aggregates.UserAggregate.Dimentions;
using Cheetah.Core.Common.DTOs;
using Cheetah.Core.Common.Specifications;
using Cheetah.Core.Interfaces;
using Cheetah.Sample.Presentation.Services.WebAPI.Controllers.EntityManager.Queries;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.EntityManager.Commands;

public class UpdateUsers(ILogger<UpdateUsers> logger, ITableCRUD simpleClassRepository, IRepository<D_User> userRepository)
    : Endpoint<UpdateUsersRequest, UpdateUsersResponse>
{
    public override void Configure()
    {
        Post(UpdateUsersRequest.Route);
        AllowAnonymous();
    }
    public override async Task HandleAsync(UpdateUsersRequest request, CancellationToken cancellationToken)
    {
        logger.LogInformation("started " + nameof(UpdateUsers) + " {@" + nameof(UpdateUsers) + "}", request);

        #region Input

        UpdateUsersResponse output_Request = new();

        #endregion

        foreach (var _user in request.UserList)
        {
            var _getUser = await userRepository.FirstOrDefaultAsync(new GetEntitySpec<D_User>(new SimpleClassDTO() { Name = _user }, EnableTrack: true));

            if (_getUser is null)
            {
                D_User user = (D_User)new D_User().SetName(_user);
                await userRepository.AddAsync(user);
            }
            else
            {
                _getUser.SetName(_user);
                await userRepository.UpdateAsync(_getUser!);
            }
        }

        #region Output

        output_Request.OutputState = new BaseClassWithNameDTO() { Id = 0 };

        #endregion

        logger.LogInformation("Ended " + nameof(UpdateUsers) + " {@" + nameof(UpdateUsers) + "}", output_Request);

        Response = output_Request.Adapt<UpdateUsersResponse>();

        return;
    }
}