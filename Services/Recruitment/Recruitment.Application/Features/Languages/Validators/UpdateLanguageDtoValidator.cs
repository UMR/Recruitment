namespace Recruitment.Application.Features.Languages;

public class UpdateLanguageDtoValidator : AbstractValidator<UpdateLanguageDto>
{
    private readonly IVisaTypeService _visaTypeService;

    public UpdateLanguageDtoValidator(IVisaTypeService visaTypeService)
    {
        _visaTypeService = visaTypeService;

        RuleFor(a => a.LanguageId)
               .NotEmpty().WithMessage("{PropertyName} is required")
               .NotNull().WithMessage("{PropertyName} is required");

        RuleFor(a => a.Name)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull().WithMessage("{PropertyName} is required")
            .MaximumLength(256).WithMessage("{PropertyName} must not exceed 256 characters");

        RuleFor(x => x)
           .Must(x => !IsExistLanguageAsync(x.Name, x.LanguageId))
           .WithMessage("Language name already exist");
    }

    private bool IsExistLanguageAsync(string visaType, int? id = null)
    {
        return _visaTypeService.IsExistVisaTypeAsync(visaType, id).Result;
    }
}
