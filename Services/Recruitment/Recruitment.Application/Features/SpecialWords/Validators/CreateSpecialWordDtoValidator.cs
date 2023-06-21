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
            .MaximumLength(200).WithMessage("{PropertyName} must not exceed 200 characters");

        RuleFor(x => x)
           .Must(x => !IsExistWordAsync(x.Word))
           .WithMessage("Name already exist");
    }

    private bool IsExistWordAsync(string emailType)
    {
        return _specialWordService.IsExistWordAsync(emailType).Result;
    }
}
