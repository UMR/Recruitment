namespace Recruitment.Application.Features.LowerCaseWords
{
    public class CreateLowerCaseWordDtoValidator : AbstractValidator<CreateLowerCaseWordDto>
    {
        private readonly ILowerCaseWordService _lowerCaseWordService;
        public CreateLowerCaseWordDtoValidator(ILowerCaseWordService lowerCaseWordService)
        {
            _lowerCaseWordService = lowerCaseWordService;

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
            return _lowerCaseWordService.IsExistWordAsync(word).Result;
        }
    }
}
