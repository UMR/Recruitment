namespace Recruitment.Application.Features.Agencies;

public class UpdateAgencyDtoValidator : AbstractValidator<UpdateAgencyDto>
{
    private readonly IAgencyService _agencyService;

    public UpdateAgencyDtoValidator(IAgencyService agencyService)
    {
        _agencyService = agencyService;

        RuleFor(a => a.AgencyId)
          .NotEmpty().WithMessage("{PropertyName} is required")
          .NotNull();

        RuleFor(a => a.AgencyName)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull()
            .MaximumLength(500).WithMessage("{PropertyName} must not exceed 500 characters");

        RuleFor(c => c.AgencyAddress)
           .MaximumLength(512).WithMessage("{PropertyName} must not exceed 512 characters");

        RuleFor(c => c.URLPrefix)
           .MaximumLength(256).WithMessage("{PropertyName} must not exceed 256 characters");

        RuleFor(c => c.AgencyEmail)
           .MaximumLength(256).WithMessage("{PropertyName} must not exceed 256 characters");

        RuleFor(c => c.AgencyPhone)
            .MaximumLength(15).WithMessage("{PropertyName} must not exceed 15 characters");

        RuleFor(c => c.AgencyContactPerson)
           .MaximumLength(256).WithMessage("{PropertyName} must not exceed 256 characters");

        RuleFor(c => c.AgencyContactPersonPhone)
           .MaximumLength(15).WithMessage("{PropertyName} must not exceed 15 characters");

        RuleFor(c => c.AgencyLoginId)
           .MaximumLength(256).WithMessage("{PropertyName} must not exceed 256 characters");

        RuleFor(x => x)
           .Must(x => !IsExistAgencyNameAsync(x.AgencyName, x.AgencyId))
           .WithMessage("Agency name already exist");
    }

    private bool IsExistAgencyNameAsync(string agencyName, long agencyId)
    {
        return _agencyService.IsExistAgencyNameAsync(agencyName).Result;
    }
}
