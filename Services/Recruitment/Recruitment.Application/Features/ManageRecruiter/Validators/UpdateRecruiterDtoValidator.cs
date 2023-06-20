namespace Recruitment.Application.Features.ManageRecruiter;

internal class UpdateRecruiterDtoValidator : AbstractValidator<UpdateRecruiterDto>
{
    private readonly IRecruiterService _recruiterService;

    public UpdateRecruiterDtoValidator(IRecruiterService recruiterService)
    {
        _recruiterService = recruiterService;   

        //RuleFor(a => a.Type)
        //    .NotEmpty().WithMessage("{PropertyName} is required")
        //    .NotNull();            

        //RuleFor(a => a.Type)
        //    .NotEmpty().WithMessage("{PropertyName} is required")
        //    .NotNull()
        //    .MaximumLength(128).WithMessage("{PropertyName} must not exceed 500 characters");

        //RuleFor(x => x)
        //   .Must(x => !IsExistEmailTypeAsync(x.Type,x.Id))
        //   .WithMessage("Email Type already exist");

    }
}

