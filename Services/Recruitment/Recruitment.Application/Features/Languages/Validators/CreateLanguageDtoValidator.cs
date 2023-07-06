namespace Recruitment.Application.Features.Languages;

public class CreateLanguageDtoValidator : AbstractValidator<CreateLanguageDto>
{
    private readonly ILanguageService _languageService;
    public CreateLanguageDtoValidator(ILanguageService languageService)
    {
        _languageService = languageService;

        RuleFor(a => a.Name)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull().WithMessage("{PropertyName} is required")
            .MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters");

        RuleFor(x => x)
           .Must(x => !IsExistLanguageAsync(x.Name))
           .WithMessage("Language name already exist");
    }

    private bool IsExistLanguageAsync(string name)
    {
        return _languageService.IsExistLanguageAsync(name).Result;
    }
}
