using FluentValidation;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands;

public class UpdateUserGuideValidator : Validator<UpdateUserGuideRequest>
{
    public UpdateUserGuideValidator()
    {
        RuleFor(x => x.Id)
           .GreaterThan(0);

        RuleFor(x => x.JsonData)
           .MinimumLength(5);

        RuleFor(x => x.Body)
            .MinimumLength(5);
    }
}
