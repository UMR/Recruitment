using AutoMapper;
using MediatR;
using Recruitment.Application.Contracts.Persistence;

namespace Recruitment.Application.Features.Menu.Queries
{
    public record GetMenusQuery : IRequest<List<MenuDto>>;

    public class GetMenusQueryHandler : IRequestHandler<GetMenusQuery, List<MenuDto>>
    {
        private readonly IMenuRepository _menuRepository;
        private readonly IMapper _mapper;

        public GetMenusQueryHandler(IMenuRepository menuRepository, IMapper mapper)
        {
            _menuRepository = menuRepository;
            _mapper = mapper;
        }

        public async Task<List<MenuDto>> Handle(GetMenusQuery request, CancellationToken cancellationToken)
        {
            var menusFromRepo = await _menuRepository.GetMenus();
            return _mapper.Map<List<MenuDto>>(menusFromRepo);
        }
    }
}
