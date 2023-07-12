namespace Recruitment.Application.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Menu, MenuListDto>().ReverseMap();
        CreateMap<Agency, AgencyListDto>().ReverseMap();
        CreateMap<EmailType, EmailTypeListDto>().ReverseMap();
        CreateMap<PositionLicenseRequirement, PositionLicenseRequirementListDto>().ReverseMap();
        CreateMap<SpecialWord, SpecialWordListDto>().ReverseMap();
        CreateMap<UpperCaseWord, UpperCaseWordListDto>().ReverseMap();
        CreateMap<LowerCaseWord, LowerCaseWordListDto>().ReverseMap();
        CreateMap<VisaTypeEntity, VisaTypeListDto>().ReverseMap();
        CreateMap<Language, LanguageListDto>().ReverseMap();
        CreateMap<Country, CountryListDto>().ReverseMap();
    }
}
