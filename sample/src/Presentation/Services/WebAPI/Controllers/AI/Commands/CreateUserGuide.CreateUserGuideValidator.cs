using FluentValidation;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands;

public class CreateUserGuideValidator : Validator<CreateUserGuideRequest>
{
    public CreateUserGuideValidator()
    {
        RuleFor(x => x.Subject)
            .MinimumLength(5);

        RuleFor(x => x.Description)
            .MinimumLength(5);

        RuleFor(x=>x.Keywords)
            .MinimumLength(5);

        RuleFor(x=>x.Body)
            .MinimumLength(5);
    }
}
