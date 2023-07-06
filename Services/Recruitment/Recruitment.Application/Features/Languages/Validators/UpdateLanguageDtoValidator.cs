namespace Recruitment.Application.Features.Languages;

public class UpdateLanguageDtoValidator : AbstractValidator<UpdateLanguageDto>
{
    private readonly ILanguageService _languageService;

    public UpdateLanguageDtoValidator(ILanguageService languageService)
    {
        _languageService = languageService;

        RuleFor(a => a.LanguageId)
               .NotEmpty().WithMessage("{PropertyName} is required")
               .NotNull().WithMessage("{PropertyName} is required");

        RuleFor(a => a.Name)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull().WithMessage("{PropertyName} is required")
            .MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters");

        RuleFor(x => x)
           .Must(x => !IsExistLanguageAsync(x.Name, x.LanguageId))
           .WithMessage("Language name already exist");
    }

    private bool IsExistLanguageAsync(string language, int? id = null)
    {
        return _languageService.IsExistLanguageAsync(language, id).Result;
    }
}
