﻿namespace Recruitment.Application.Features.SpecialWords;

public class UpdateUpperCaseWordDtoValidator : AbstractValidator<UpdateUpperCaseWordDto>
{
    private readonly IUpperCaseWordService _specialWordService;

    public UpdateUpperCaseWordDtoValidator(IUpperCaseWordService specialWordService)
    {
        _specialWordService = specialWordService;

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

    public UpdateUpperCaseWordDtoValidator()
    {

    }

    private bool IsExistWordAsync(string word, long? id = null)
    {
        return _specialWordService.IsExistWordAsync(word, id).Result;
    }
}
