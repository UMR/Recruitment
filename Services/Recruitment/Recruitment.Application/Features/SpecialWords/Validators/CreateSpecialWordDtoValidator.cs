﻿namespace Recruitment.Application.Features.SpecialWords;

public class CreateUpperCaseWordDtoValidator:AbstractValidator<CreateSpecialWordDto>
{
    private readonly IUpperCaseWordService _specialWordService;
    public CreateUpperCaseWordDtoValidator(IUpperCaseWordService specialWordService)
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
