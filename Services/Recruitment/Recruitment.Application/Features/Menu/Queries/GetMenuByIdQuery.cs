using AutoMapper;
using MediatR;
using Recruitment.Application.Contracts.Persistence;
using Recruitment.Application.Features.Menu.Dtos;

namespace Recruitment.Application.Features.Menu.Queries
{
    public record GetMenuByIdQuery : IRequest<MenuListDto> 
    {
        public int Id { get; set; }
    }

    public class GetMenuByIdQueryHandler : IRequestHandler<GetMenuByIdQuery, MenuListDto>
    {
        private readonly IMenuRepository _menuRepository;
        private readonly IMapper _mapper;

        public GetMenuByIdQueryHandler(IMenuRepository menuRepository, IMapper mapper)
        {
            _menuRepository = menuRepository;
            _mapper = mapper;
        }

        public async Task<MenuListDto> Handle(GetMenuByIdQuery request, CancellationToken cancellationToken)
        {
            var menuFromRepo = await _menuRepository.GetMenuById(request.Id);
            return _mapper.Map<MenuListDto>(menuFromRepo);
        }
    }
}
