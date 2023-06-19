namespace Recruitment.Application.Features.EmailTypes;

internal class UpdateEmailTypeDtoValidator: AbstractValidator<UpdateEmailTypeDto>
{
    private readonly IEmailTypeService _emailTypeService;

    public UpdateEmailTypeDtoValidator(IEmailTypeService emailTypeService)
    {
        _emailTypeService = emailTypeService;   

        RuleFor(a => a.Type)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull();            

        RuleFor(a => a.Type)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull()
            .MaximumLength(128).WithMessage("{PropertyName} must not exceed 500 characters");

        RuleFor(x => x)
           .Must(x => !IsExistEmailTypeAsync(x.Type,x.Id))
           .WithMessage("Email Type already exist");

    }

    private bool IsExistEmailTypeAsync(string emailType, int id)
    {
        return _emailTypeService.IsExistEmailTypeAsync(emailType, id).Result;
    }
}

