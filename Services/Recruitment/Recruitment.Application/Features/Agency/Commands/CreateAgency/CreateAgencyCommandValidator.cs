using FluentValidation;

namespace Recruitment.Application.Features.Agency.Commands.CreateAgency
{
    public class CreateAgencyCommandValidator : AbstractValidator<CreateAgencyCommand>
    {
        public CreateAgencyCommandValidator()
        {
            RuleFor(a => a.AgencyName)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull()
                .MaximumLength(128).WithMessage("{PropertyName} must not exceed 500 characters");

            RuleFor(c => c.CreatedBy)
               .NotEmpty().WithMessage("{PropertyName} is required")
               .NotNull();

            RuleFor(c => c.CreatedDate)
               .NotEmpty().WithMessage("{PropertyName} is required")
               .NotNull();
        }
    }
}
