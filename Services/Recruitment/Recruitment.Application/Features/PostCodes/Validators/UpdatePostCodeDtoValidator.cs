using Recruitment.Application.Features.VisaTypes;

namespace Recruitment.Application.Features.PostCodes;

public class UpdatePostCodeDtoValidator : AbstractValidator<UpdatePostCodeDto>
{
    private readonly IPostCodeService _postCodeService;

    public UpdatePostCodeDtoValidator(IPostCodeService postCodeService)
    {
        _postCodeService = postCodeService;

        RuleFor(a => a.PostCode)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull().WithMessage("{PropertyName} is required")
            .MaximumLength(256).WithMessage("{PropertyName} must not exceed 200 characters");

        RuleFor(a => a.PostCodeId)
           .NotEmpty().WithMessage("{PropertyName} is required")
           .NotNull().WithMessage("{PropertyName} is required");

        RuleFor(a => a.CountryId)
           .NotEmpty().WithMessage("{PropertyName} is required")
           .NotNull().WithMessage("{PropertyName} is required");        

        RuleFor(x => x)
           .Must(x => !IsExistPostCodeAsync(x.PostCode,x.PostCodeId))
           .WithMessage("Post Code already exist");
    }

    private bool IsExistPostCodeAsync(string postCode, int? id = null)
    {
        return _postCodeService.IsExistPostCodeAsync(postCode, id).Result;
    }
}
