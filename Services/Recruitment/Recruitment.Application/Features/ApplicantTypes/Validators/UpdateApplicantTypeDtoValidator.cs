namespace Recruitment.Application.Features.ApplicantType;

internal class UpdateApplicantTypeDtoValidator : AbstractValidator<UpdateApplicantTypeDto>
{
    private readonly IApplicantTypeService _applicantTypeService;

    public UpdateApplicantTypeDtoValidator(IApplicantTypeService applicantTypeService)
    {
        _applicantTypeService = applicantTypeService;  
    }

    private bool IsExistEmailTypeAsync(string emailType, int id)
    {
        return _applicantTypeService.IsExistAsync(emailType, id).Result;
    }
}

