
namespace Recruitment.Application.Features.Users
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<List<ActiveUsersDtos>> GetActiveUserAsync()
        {
            var entitiesFromRepo = await _userRepository.GetActiveUsers();
            var entitiesToReturn = _mapper.Map<List<ActiveUsersDtos>>(entitiesFromRepo);
            return entitiesToReturn; ;
        }
    }
}
