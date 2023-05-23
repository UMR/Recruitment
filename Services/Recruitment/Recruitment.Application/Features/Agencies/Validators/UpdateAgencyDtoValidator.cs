using Recruitment.Application.Features.Agencies.Dtos;

namespace Recruitment.Application.Features.Agencies.Validators
{
    public class UpdateAgencyCommandValidator : AbstractValidator<UpdateAgencyDto>
    {
        public UpdateAgencyCommandValidator()
        {
            RuleFor(a => a.AgencyName)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull()
                .MaximumLength(128).WithMessage("{PropertyName} must not exceed 500 characters");

            RuleFor(c => c.UpdatedBy)
               .NotEmpty().WithMessage("{PropertyName} is required")
               .NotNull();

            RuleFor(c => c.UpdatedDate)
               .NotEmpty().WithMessage("{PropertyName} is required")
               .NotNull();
        }
    }
}
