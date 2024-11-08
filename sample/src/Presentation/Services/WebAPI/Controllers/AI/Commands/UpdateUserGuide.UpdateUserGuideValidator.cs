using FluentValidation;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands;

public class UpdateUserGuideValidator : Validator<UpdateUserGuideRequest>
{
    public UpdateUserGuideValidator()
    {
        RuleFor(x => x.Id)
           .GreaterThan(0);

        RuleFor(x => x.Subject)
           .MinimumLength(5);

        RuleFor(x => x.Description)
            .MinimumLength(5);

        RuleFor(x => x.Keywords)
            .MinimumLength(5);

        RuleFor(x => x.Body)
            .MinimumLength(5);
    }
}
