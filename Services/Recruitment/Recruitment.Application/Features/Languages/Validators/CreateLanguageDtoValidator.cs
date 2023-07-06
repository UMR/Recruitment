namespace Recruitment.Application.Features.Languages;

public class CreateLanguageDtoValidator : AbstractValidator<CreateLanguageDto>
{
    private readonly IVisaTypeService _visaTypeService;
    public CreateLanguageDtoValidator(IVisaTypeService visaTypeService)
    {
        _visaTypeService = visaTypeService;

        RuleFor(a => a.Name)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull().WithMessage("{PropertyName} is required")
            .MaximumLength(256).WithMessage("{PropertyName} must not exceed 256 characters");

        RuleFor(x => x)
           .Must(x => !IsExistLanguageAsync(x.Name))
           .WithMessage("Language name already exist");
    }

    private bool IsExistLanguageAsync(string visaType)
    {
        return _visaTypeService.IsExistVisaTypeAsync(visaType).Result;
    }
}
