namespace Recruitment.Application.Features.EmailTypes;

internal class CreateEmailTypeDtoValidator  : AbstractValidator<CreateEmailTypeDto>
{
    public CreateEmailTypeDtoValidator()
    {
        RuleFor(a => a.Type)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull()
            .MaximumLength(128).WithMessage("{PropertyName} must not exceed 500 characters");        
    }
}
