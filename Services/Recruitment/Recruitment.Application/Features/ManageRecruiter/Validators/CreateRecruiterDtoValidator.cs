namespace Recruitment.Application.Features.ManageRecruiter;

internal class CreateRecruiterDtoValidator : AbstractValidator<CreateRecruiterDto>
{
    private readonly IRecruiterService _recruiterService;
    public CreateRecruiterDtoValidator(IRecruiterService recruiterService)
    {
        _recruiterService = recruiterService;

        //RuleFor(a => a.Type)
        //    .NotEmpty().WithMessage("{PropertyName} is required")
        //    .NotNull()
        //    .MaximumLength(128).WithMessage("{PropertyName} must not exceed 500 characters");

        //RuleFor(x => x)
        //   .Must(x => !IsExistEmailTypeAsync(x.Type))
        //   .WithMessage("Email Type already exist");
    }
}
