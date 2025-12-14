using Cheetah.Core.Aggregates.UserAggregate.Dimentions;
using Cheetah.Core.Common.DTOs;
using Cheetah.Core.Common.Specifications;
using Cheetah.Core.Interfaces;
using Cheetah.Sample.Infrastructure.Identity;
using Cheetah.Sample.Presentation.Services.WebAPI.Controllers.EntityManager.Queries;
using Microsoft.AspNetCore.Identity;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.EntityManager.Commands;

public class UpdateUsers(ILogger<UpdateUsers> logger,
    ITableCRUD simpleClassRepository,
    IRepository<D_User> userRepository,
    UserManager<ApplicationUser> userManager)
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
            var _getUser = await userRepository
                .FirstOrDefaultAsync(new GetEntitySpec<D_User>(new SimpleClassDTO() { Name = _user.Name! }, EnableTrack: true));

            if (_getUser is null)
            {
                D_User user = (D_User)new D_User()
                    .SetName(_user.Name)
                    .SetDisplayName(_user.DisplayName);

                await userRepository.AddAsync(user);

                ApplicationUser _applicationUser = new()
                {
                    UserName = _user.Name,
                    Email = _user.Name + "@behparvar.com",
                    EmailConfirmed = true
                };

                await userManager.CreateAsync(_applicationUser);
            }
            else
            {
                _getUser
                    .SetName(_user.Name)
                    .SetDisplayName(_user.DisplayName);

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