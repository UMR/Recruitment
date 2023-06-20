namespace Recruitment.Application.Features.PositionLicenseRequirements
{
    public class CreatePositionLicenseRequirementDtoValidator : AbstractValidator<CreatePositionLicenseRequirementDto>
    {
        private readonly IPositionLicenseRequirementService _positionLicenseRequirementService;
        public CreatePositionLicenseRequirementDtoValidator(IPositionLicenseRequirementService positionLicenseRequirementService)
        {
            _positionLicenseRequirementService = positionLicenseRequirementService;

            RuleFor(a => a.PositionLicenseRequirementName)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull().WithMessage("{PropertyName} is required")
                .MaximumLength(200).WithMessage("{PropertyName} must not exceed 200 characters");

            RuleFor(x => x)
               .Must(x => !IsExistNameAsync(x.PositionLicenseRequirementName))
               .WithMessage("Name already exist");
        }

        private bool IsExistNameAsync(string emailType)
        {
            return _positionLicenseRequirementService.IsExistNameAsync(emailType).Result;
        }
    }
}
