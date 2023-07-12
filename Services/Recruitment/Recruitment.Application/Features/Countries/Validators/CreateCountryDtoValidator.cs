namespace Recruitment.Application.Features.Countries;

public class CreateCountryDtoValidator : AbstractValidator<CreateCountryDto>
{
    private readonly ICountryService _countryService;
    public CreateCountryDtoValidator(ICountryService countryService)
    {
        _countryService = countryService;

        RuleFor(a => a.CountryName)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull().WithMessage("{PropertyName} is required")
            .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters");

        RuleFor(a => a.Description)            
            .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters");

        RuleFor(x => x)
           .Must(x => !IsExistNameAsync(x.CountryName))
           .WithMessage("Name already exist");
    }

    private bool IsExistNameAsync(string name)
    {
        return _countryService.IsExistNameAsync(name).Result;
    }
}
