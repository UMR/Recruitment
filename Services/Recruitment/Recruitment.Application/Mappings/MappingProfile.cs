using Recruitment.Application.Features.Menu.Queries;

namespace Recruitment.Application.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Menu, MenuDto>().ReverseMap();
        CreateMap<Agency, AgencyListDto>().ReverseMap();
        CreateMap<Agency, CreateAgencyDto>().ReverseMap();
        CreateMap<Agency, UpdateAgencyDto>().ReverseMap();
    }
}
