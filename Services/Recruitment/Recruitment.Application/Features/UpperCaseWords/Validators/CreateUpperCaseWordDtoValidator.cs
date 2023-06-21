namespace Recruitment.Application.Features.UpperCaseWords;

public class CreateUpperCaseWordDtoValidator:AbstractValidator<CreateUpperCaseWordDto>
{
    private readonly IUpperCaseWordService _upperCaseWordService;
    public CreateUpperCaseWordDtoValidator(IUpperCaseWordService upperCaseWordService)
    {
        _upperCaseWordService = upperCaseWordService;

        RuleFor(a => a.Word)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull().WithMessage("{PropertyName} is required")
            .MaximumLength(256).WithMessage("{PropertyName} must not exceed 256 characters");

        RuleFor(x => x)
           .Must(x => !IsExistWordAsync(x.Word))
           .WithMessage("Word already exist");
    }

    private bool IsExistWordAsync(string word)
    {
        return _upperCaseWordService.IsExistWordAsync(word).Result;
    }
}
