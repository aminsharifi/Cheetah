using Cheetah.Core.Common;

namespace Cheetah.UseCases.Validations;

public class BaseEntityValidation : AbstractValidator<BaseEntity>
{
    public BaseEntityValidation()
    {
        RuleFor(p => p.Name).NotEmpty().WithMessage("وارد کردن نام ضروری است");
        RuleFor(p => p.Name).MaximumLength(512).WithMessage("حداکثر 512 کاراکتر می توان وارد کرد");
        RuleFor(p => p.Name).MinimumLength(3).WithMessage("حداقل 3 کاراکتر برای نام وارد کنید");

        RuleFor(p => p.DisplayName).NotEmpty().WithMessage("وارد کردن نام نمایشی ضروری است");
        RuleFor(p => p.DisplayName).MaximumLength(512).WithMessage("حداکثر 512 کاراکتر می توان وارد کرد");
        RuleFor(p => p.Name).MinimumLength(3).WithMessage("حداقل 3 کاراکتر برای نام نمایشی وارد کنید");
    }
}