namespace Recruitment.Application.Features.ApplicantType;

internal class CreateApplicantTypeDtoValidator : AbstractValidator<CreateApplicantTypeDto>
{
    private readonly IApplicantTypeService _applicantTypeService;
    public CreateApplicantTypeDtoValidator(IApplicantTypeService applicantTypeService)
    {
        _applicantTypeService = applicantTypeService;

        RuleFor(a => a.Name)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull().WithMessage("{PropertyName} is required")
            .MaximumLength(128).WithMessage("{PropertyName} must not exceed 500 characters");
    }

    private bool IsExistApplicantTypeAsync(string emailType)
    {
        return _applicantTypeService.IsExistAsync(emailType).Result;
    }
}
