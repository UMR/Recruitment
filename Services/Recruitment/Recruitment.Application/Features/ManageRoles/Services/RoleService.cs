namespace Recruitment.Application.Features.ManageRole;

public class RoleService : IRoleService
{
    private readonly IMapper _mapper;
    private readonly ICurrentUserService _currentUserService;
    private readonly IDateTimeService _dateTime;
    private readonly IRoleRepository _roleRepository;

    public RoleService(IMapper mapper, ICurrentUserService currentUserService, IDateTimeService dateTime, IRoleRepository roleRepository)
    {
        _mapper = mapper;
        _currentUserService = currentUserService;
        _dateTime = dateTime;
        _roleRepository = roleRepository;
    }

    public async Task<List<RoleListDto>> GetAllAsync()
    {
        try
        {
            var entitiesFromRepo = await _roleRepository.GetAllAsync();
            var entitiesToReturn = _mapper.Map<List<RoleListDto>>(entitiesFromRepo);
            return entitiesToReturn;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<RoleListDto> GetByIdAsync(int id)
    {
        var entityFromRepo = await _roleRepository.GetByIdAsync(id);
        var entityToReturn = _mapper.Map<RoleListDto>(entityFromRepo);
        return entityToReturn;
    }

    public async Task<bool> IsExistAsync(string roleName, int? id = null)
    {
        return await _roleRepository.IsExistAsync(roleName, id);
    }

    public async Task<BaseCommandResponse> CreateAsync(CreateRoleDto request)
    {
        var response = new BaseCommandResponse();
        var validator = new CreateRoleDtoValidator(this);
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.IsValid == false)
        {
            response.Success = false;
            response.Message = "Creating Failed";
            response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
            return response;
        }

        var entity = new Role
        {
            RoleName = request.Name,
            CreatedBy = _currentUserService.UserId,
            CreatedDate = _dateTime.Now
        };
        await _roleRepository.CreateAsync(entity);

        response.Success = true;
        response.Message = "Creating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> UpdateAsync(int id, UpdateRoleDto request)
    {
        var response = new BaseCommandResponse();
        var validator = new UpdateRoleDtoValidator(this);
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.IsValid == false)
        {
            response.Success = false;
            response.Message = "Updating Failed";
            response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
            return response;
        }

        if (id != request.Id)
        {
            throw new BadRequestException("Id does not match");
        }

        var entity = await _roleRepository.GetByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(Role), id.ToString());
        }

        entity.RoleId = request.Id;
        entity.RoleName = request.name;
        entity.UpdatedBy = _currentUserService.UserId;
        entity.UpdatedDate = _dateTime.Now;
        await _roleRepository.UpdateAsync(id, entity);

        response.Success = true;
        response.Message = "Updating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> DeleteAsync(int id)
    {
        var response = new BaseCommandResponse();
        var entity = await _roleRepository.GetByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(Role), id.ToString());
        }

        var result = await _roleRepository.DeleteAsync(id);

        if (!string.IsNullOrEmpty(result))
        {
            response.Success = false;
            response.Message = result;
            return response;
        }

        response.Success = true;
        response.Message = "Deleting Successful";
        return response;
    }

    public async Task<List<RoleListDto>> GetRoleByUserAsync(int userId)
    {
        try
        {
            var entitiesFromRepo = await _roleRepository.GetRoleByUserAsync(userId);
            var entitiesToReturn = _mapper.Map<List<RoleListDto>>(entitiesFromRepo);
            return entitiesToReturn;
        }
        catch (Exception)
        {
            throw;
        }
    }
}
