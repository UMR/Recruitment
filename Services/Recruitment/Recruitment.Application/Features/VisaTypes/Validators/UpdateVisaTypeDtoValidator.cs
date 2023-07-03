namespace Recruitment.Application.Features.VisaTypes;

public class UpdateVisaTypeDtoValidator : AbstractValidator<UpdateVisaTypeDto>
{
    private readonly IVisaTypeService _visaTypeService;

    public UpdateVisaTypeDtoValidator(IVisaTypeService visaTypeService)
    {
        _visaTypeService = visaTypeService;

        RuleFor(a => a.Id)
               .NotEmpty().WithMessage("{PropertyName} is required")
               .NotNull().WithMessage("{PropertyName} is required");

        RuleFor(a => a.VisaTypeName)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull().WithMessage("{PropertyName} is required")
            .MaximumLength(256).WithMessage("{PropertyName} must not exceed 256 characters");

        RuleFor(x => x)
           .Must(x => !IsExistWordAsync(x.VisaTypeName, x.Id))
           .WithMessage("Word already exist");
    }

    private bool IsExistWordAsync(string visaType, int? id = null)
    {
        return _visaTypeService.IsExistVisaTypeAsync(visaType, id).Result;
    }
}
