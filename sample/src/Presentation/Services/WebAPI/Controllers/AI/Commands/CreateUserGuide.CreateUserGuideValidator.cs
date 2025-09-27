using FluentValidation;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands;

public class CreateUserGuideValidator : Validator<CreateUserGuideRequest>
{
    public CreateUserGuideValidator()
    {

        RuleFor(x=>x.JsonData)
            .MinimumLength(5);

        RuleFor(x=>x.Body)
            .MinimumLength(5);
    }
}
