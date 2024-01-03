namespace Cheetah.Application.Business.D_Tag.Commands.CreateD_Tag;
public class CreateD_TagCommandValidator : AbstractValidator<CreateD_TagCommand>
{
    public CreateD_TagCommandValidator()
    {
        RuleFor(v => v.Name)
            .MaximumLength(10)
            .NotEmpty();
    }
}