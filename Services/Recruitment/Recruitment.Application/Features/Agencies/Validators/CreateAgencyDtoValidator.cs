﻿namespace Recruitment.Application.Features.Agencies
{
    public class CreateAgencyDtoValidator : AbstractValidator<CreateAgencyDto>
    {
        public CreateAgencyDtoValidator()
        {
            RuleFor(a => a.AgencyName)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull()
                .MaximumLength(500).WithMessage("{PropertyName} must not exceed 500 characters");

            RuleFor(c => c.CreatedBy)
               .NotEmpty().WithMessage("{PropertyName} is required")
               .NotNull();

            RuleFor(c => c.CreatedDate)
               .NotEmpty().WithMessage("{PropertyName} is required")
               .NotNull();
        }
    }
}
