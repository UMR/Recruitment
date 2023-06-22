namespace Recruitment.Application.Features.ApplicantType;

internal class UpdateApplicantTypeDtoValidator : AbstractValidator<UpdateApplicantTypeDto>
{
    private readonly IApplicantTypeService _applicantTypeService;

    public UpdateApplicantTypeDtoValidator(IApplicantTypeService applicantTypeService)
    {
        _applicantTypeService = applicantTypeService;   

        RuleFor(a => a.Id)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull().WithMessage("{PropertyName} is required");            

        RuleFor(a => a.Name)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull().WithMessage("{PropertyName} is required")
            .MaximumLength(128).WithMessage("{PropertyName} must not exceed 50 characters");

    }

    private bool IsExistEmailTypeAsync(string emailType, int id)
    {
        return _applicantTypeService.IsExistAsync(emailType, id).Result;
    }
}

