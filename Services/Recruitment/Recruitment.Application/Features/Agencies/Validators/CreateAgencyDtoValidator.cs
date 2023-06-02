namespace Recruitment.Application.Features.Agencies
{
    public class CreateAgencyDtoValidator : AbstractValidator<CreateAgencyDto>
    {
        public CreateAgencyDtoValidator()
        {
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
        }
    }
}
