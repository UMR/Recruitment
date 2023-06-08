namespace Recruitment.Application.Features.EmailTypes;

internal class UpdateEmailTypeDtoValidator: AbstractValidator<UpdateEmailTypeDto>
{
    public UpdateEmailTypeDtoValidator()
    {
        RuleFor(a => a.Type)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull();            

        RuleFor(a => a.Type)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull()
            .MaximumLength(128).WithMessage("{PropertyName} must not exceed 500 characters");

        RuleFor(c => c.IsOfficial)
           .NotEmpty().WithMessage("{PropertyName} is required")
           .NotNull();

        RuleFor(c => c.IsPersonal)
           .NotEmpty().WithMessage("{PropertyName} is required")
           .NotNull();
    }
}

