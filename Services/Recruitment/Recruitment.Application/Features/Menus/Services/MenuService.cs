namespace Recruitment.Application.Features.Menus;

internal class MenuService : IMenuService
{
    private readonly IMapper _mapper;
    private readonly ICurrentUserService _currentUserService;
    private readonly IDateTimeService _dateTime;
    private readonly IMenuRepository _menuRepository;

    public MenuService(IMapper mapper, ICurrentUserService currentUserService, IDateTimeService dateTime, IMenuRepository menuRepository)
    {
        _mapper = mapper;
        _currentUserService = currentUserService;
        _dateTime = dateTime;
        _menuRepository = menuRepository;
    }

    public async Task<List<MenuListDto>> GetMenusAsync()
    {
        var menusFromRepo = await _menuRepository.GetMenus();
        var menusToReturn = _mapper.Map<List<MenuListDto>>(menusFromRepo);
        return menusToReturn;
    }

    public async Task<MenuListDto> GetMenuByIdAsync(int id)
    {
        var menuFromRepo = await _menuRepository.GetMenuById(id);
        var menuToReturn = _mapper.Map<MenuListDto>(menuFromRepo);
        return menuToReturn;
    }
}
