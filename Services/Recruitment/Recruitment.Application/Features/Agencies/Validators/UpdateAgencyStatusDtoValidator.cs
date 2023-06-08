namespace Recruitment.Application.Features.Agencies;

public class UpdateAgencyStatusDtoValidator : AbstractValidator<UpdateAgencyStatusDto>
{
    public UpdateAgencyStatusDtoValidator()
    {
        RuleFor(a => a.AgencyId)
          .NotEmpty().WithMessage("{PropertyName} is required")
          .NotNull();

        //RuleFor(c => c.IsActive)
        //    .NotEmpty().WithMessage("{PropertyName} is required")
        //    .NotNull();
    }
}
