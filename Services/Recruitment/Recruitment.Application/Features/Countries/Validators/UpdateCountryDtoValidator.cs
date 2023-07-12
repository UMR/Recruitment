namespace Recruitment.Application.Features.Countries;

public class UpdateCountryDtoValidator : AbstractValidator<UpdateCountryDto>
{
    private readonly ICountryService _countryService;
    public UpdateCountryDtoValidator(ICountryService countryService)
    {
        _countryService = countryService;

        RuleFor(a => a.CountryId)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull().WithMessage("{PropertyName} is required");

        RuleFor(a => a.CountryName)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull().WithMessage("{PropertyName} is required")
            .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters");

        RuleFor(a => a.Description)
            .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters");

        RuleFor(x => x)
           .Must(x => !IsExistNameAsync(x.CountryName,x.CountryId))
           .WithMessage("Name already exist");
    }

    private bool IsExistNameAsync(string name, int id)
    {
        return _countryService.IsExistNameAsync(name, id).Result;
    }
}