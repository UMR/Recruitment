using AutoMapper;
using MediatR;
using Recruitment.Application.Contracts.Persistence;
using Recruitment.Application.Features.Menu.Dtos;

namespace Recruitment.Application.Features.Menu.Queries
{
    public record GetMenusQuery : IRequest<List<MenuListDto>>;

    public class GetMenusQueryHandler : IRequestHandler<GetMenusQuery, List<MenuListDto>>
    {
        private readonly IMenuRepository _menuRepository;
        private readonly IMapper _mapper;

        public GetMenusQueryHandler(IMenuRepository menuRepository, IMapper mapper)
        {
            _menuRepository = menuRepository;
            _mapper = mapper;
        }

        public async Task<List<MenuListDto>> Handle(GetMenusQuery request, CancellationToken cancellationToken)
        {
            var menusFromRepo = await _menuRepository.GetMenus();
            return _mapper.Map<List<MenuListDto>>(menusFromRepo);
        }
    }
}
