using FluentValidation;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands;

public class DeleteUserGuideValidator : Validator<DeleteUserGuideRequest>
{
    public DeleteUserGuideValidator()
    {
        //RuleFor(x => x.Id)
        //    .GreaterThan(0);
    }
}
