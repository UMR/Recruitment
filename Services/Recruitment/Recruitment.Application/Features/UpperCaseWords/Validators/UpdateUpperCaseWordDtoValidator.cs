namespace Recruitment.Application.Features.UpperCaseWords;

public class UpdateUpperCaseWordDtoValidator : AbstractValidator<UpdateUpperCaseWordDto>
{
    private readonly IUpperCaseWordService _upperCaseWordService;

    public UpdateUpperCaseWordDtoValidator(IUpperCaseWordService upperCaseWordService)
    {
        _upperCaseWordService = upperCaseWordService;

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

    private bool IsExistWordAsync(string word, long? id = null)
    {
        return _upperCaseWordService.IsExistWordAsync(word, id).Result;
    }
}
