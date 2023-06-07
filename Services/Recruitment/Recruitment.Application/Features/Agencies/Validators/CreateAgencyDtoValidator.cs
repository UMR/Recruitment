namespace Recruitment.Application.Features.Agencies;

public class CreateAgencyDtoValidator : AbstractValidator<CreateAgencyDto>
{  
    private readonly IAgencyService _agencyService;

    public CreateAgencyDtoValidator(IAgencyService agencyService)
    {
        _agencyService = agencyService;

        RuleFor(a => a.AgencyName)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull()
            .MaximumLength(500).WithMessage("{PropertyName} must not exceed 500 characters");

        RuleFor(a => a.AgencyAddress)
           .MaximumLength(512).WithMessage("{PropertyName} must not exceed 512 characters");

        RuleFor(a => a.URLPrefix)
           .MaximumLength(256).WithMessage("{PropertyName} must not exceed 256 characters");

        RuleFor(a => a.AgencyEmail)
           .MaximumLength(256).WithMessage("{PropertyName} must not exceed 256 characters");

        RuleFor(a => a.AgencyPhone)
            .MaximumLength(15).WithMessage("{PropertyName} must not exceed 15 characters");

        RuleFor(a => a.AgencyContactPerson)
           .MaximumLength(256).WithMessage("{PropertyName} must not exceed 256 characters");

        RuleFor(a => a.AgencyContactPersonPhone)
           .MaximumLength(15).WithMessage("{PropertyName} must not exceed 15 characters");

        RuleFor(a => a.AgencyLoginId)
           .MaximumLength(256).WithMessage("{PropertyName} must not exceed 256 characters");

        RuleFor(x => x)
           .Must(x => !IsExistAgencyNameAsync(x.AgencyName))
           .WithMessage("Agency name already exist");

    }

    private bool IsExistAgencyNameAsync(string agencyName)
    {        
        return _agencyService.IsExistAgencyNameAsync(agencyName).Result;
    }
}
