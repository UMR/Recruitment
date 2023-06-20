namespace Recruitment.Application.Features.EmailTypes;

internal class CreateEmailTypeDtoValidator  : AbstractValidator<CreateEmailTypeDto>
{
    private readonly IEmailTypeService _emailTypeService;
    public CreateEmailTypeDtoValidator(IEmailTypeService emailTypeService)
    {
        _emailTypeService = emailTypeService;

        RuleFor(a => a.Type)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull()
            .MaximumLength(128).WithMessage("{PropertyName} must not exceed 500 characters");

        RuleFor(x => x)
           .Must(x => !IsExistEmailTypeAsync(x.Type))
           .WithMessage("Email Type already exist");
    }

    private bool IsExistEmailTypeAsync(string emailType)
    {
        return _emailTypeService.IsExistAsync(emailType).Result;
    }
}
