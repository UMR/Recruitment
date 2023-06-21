namespace Recruitment.Application.Features.SpecialWords;

public class CreateSpecialWordDtoValidator:AbstractValidator<CreateSpecialWordDto>
{
    private readonly ISpecialWordService _specialWordService;
    public CreateSpecialWordDtoValidator(ISpecialWordService specialWordService)
    {
        _specialWordService = specialWordService;

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
        return _specialWordService.IsExistWordAsync(word).Result;
    }
}
