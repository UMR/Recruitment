namespace Recruitment.Application.Features.Agencies
{
    public class UpdateAgencyDtoValidator : AbstractValidator<UpdateAgencyDto>
    {
        public UpdateAgencyDtoValidator()
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
