namespace Recruitment.Application.Features.InstitutionTypes;

internal class CreateInstitutionTypeDtoValidator : AbstractValidator<CreateInstitutionTypeDto>
{
    public CreateInstitutionTypeDtoValidator()
    {
        RuleFor(a => a.InstituteType)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull()
            .MaximumLength(128).WithMessage("{PropertyName} must not exceed 128 characters");

        RuleFor(c => c.Description)
           .NotEmpty().WithMessage("{PropertyName} is required")
           .MaximumLength(10).WithMessage("{PropertyName} must not exceed 10 characters")
           .NotNull();

    }
}
