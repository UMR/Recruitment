namespace Recruitment.Application.Features.LowerCaseWords;

public class UpdateLowerCaseWordDtoValidator : AbstractValidator<UpdateLowerCaseWordDto>
{
    private readonly ILowerCaseWordService _lowerCaseWordService;
    public UpdateLowerCaseWordDtoValidator(ILowerCaseWordService lowerCaseWordService)
    {
        _lowerCaseWordService = lowerCaseWordService;

        RuleFor(a => a.Id)
               .NotEmpty().WithMessage("{PropertyName} is required")
               .NotNull().WithMessage("{PropertyName} is required");

        RuleFor(a => a.Word)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull().WithMessage("{PropertyName} is required")
            .MaximumLength(256).WithMessage("{PropertyName} must not exceed 256 characters");

        RuleFor(x => x)
           .Must(x => !IsExistWordAsync(x.Word, x.Id))
           .WithMessage("Word already exist");
    }

    private bool IsExistWordAsync(string word, long id)
    {
        return _lowerCaseWordService.IsExistWordAsync(word, id).Result;
    }
}
