namespace Recruitment.Application.Features.VisaTypes;

public class CreateVisaTypeDtoValidator : AbstractValidator<CreateVisaTypeDto>
{
    private readonly IVisaTypeService _visaTypeService;
    public CreateVisaTypeDtoValidator(IVisaTypeService visaTypeService)
    {
        _visaTypeService = visaTypeService;

        RuleFor(a => a.VisaType)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull().WithMessage("{PropertyName} is required")
            .MaximumLength(256).WithMessage("{PropertyName} must not exceed 256 characters");

        RuleFor(x => x)
           .Must(x => !IsExistVisaTypeAsync(x.VisaType))
           .WithMessage("Word already exist");
    }

    private bool IsExistVisaTypeAsync(string visaType)
    {
        return _visaTypeService.IsExistVisaTypeAsync(visaType).Result;
    }
}
