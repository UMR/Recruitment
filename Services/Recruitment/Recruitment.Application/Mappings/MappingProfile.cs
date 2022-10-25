using AutoMapper;
using Recruitment.Application.Features.Menu.Queries;
using Recruitment.Domain.Entities;

namespace Recruitment.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Menu, MenuDto>().ReverseMap();
            CreateMap<Agency, AgencyDto>().ReverseMap();
        }
    }
}
