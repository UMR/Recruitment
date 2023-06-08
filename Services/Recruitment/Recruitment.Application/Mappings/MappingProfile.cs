﻿namespace Recruitment.Application.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Menu, MenuListDto>().ReverseMap();
        CreateMap<Agency, AgencyListDto>().ReverseMap();
        CreateMap<EmailType, EmailTypeListDto>().ReverseMap();
    }
}
