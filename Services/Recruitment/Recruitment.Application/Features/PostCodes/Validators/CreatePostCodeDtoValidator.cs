namespace Recruitment.Application.Features.PostCodes;

public class CreatePostCodeDtoValidator : AbstractValidator<CreatePostCodeDto>
{
    private readonly IPostCodeService _postCodeService;
    public CreatePostCodeDtoValidator(IPostCodeService postCodeService)
    {
        _postCodeService = postCodeService;

        RuleFor(a => a.PostCode)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull().WithMessage("{PropertyName} is required")
            .MaximumLength(256).WithMessage("{PropertyName} must not exceed 200 characters");

        RuleFor(a => a.CountryId)
           .NotEmpty().WithMessage("{PropertyName} is required")
           .NotNull().WithMessage("{PropertyName} is required");           

        RuleFor(x => x)
           .Must(x => !IsExistPostCodeAsync(x.PostCode))
           .WithMessage("Post Code already exist");
    }

    private bool IsExistPostCodeAsync(string visaType)
    {
        return _postCodeService.IsExistPostCodeAsync(visaType).Result;
    }
}
