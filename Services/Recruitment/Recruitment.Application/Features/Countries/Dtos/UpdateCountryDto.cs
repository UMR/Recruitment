namespace Recruitment.Application.Features.Countries;

public class UpdateCountryDto
{
    public int CountryId { get; set; }
    public string CountryName { get; set; } = null!;
    public string Description { get; set; } = null;
}
