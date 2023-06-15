namespace Recruitment.Application.Features.InstitutionTypes;

internal class UpdateInstitutionTypeDtoValidator : AbstractValidator<UpdateInstitutionTypeDto>
{
    public UpdateInstitutionTypeDtoValidator()
    {
        RuleFor(a => a.InstituteType)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull();            

        RuleFor(a => a.Description)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull()
            .MaximumLength(10).WithMessage("{PropertyName} must not exceed 10 characters");
    }
}

