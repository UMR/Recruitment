using Recruitment.Domain.Entities;

namespace Recruitment.Application.Features.PositionLicenseRequirements
{
    public class PositionLicenseRequirementService : IPositionLicenseRequirementService
    {
        private readonly IMapper _mapper;
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTimeService _dateTime;
        private readonly IPositionLicenseRequirementRepository _positionLicenseRequirementRepository;

        public PositionLicenseRequirementService(IMapper mapper, ICurrentUserService currentUserService, IDateTimeService dateTime, IPositionLicenseRequirementRepository positionLicenseRequirementRepository)
        {
            _mapper = mapper;
            _currentUserService = currentUserService;
            _dateTime = dateTime;
            _positionLicenseRequirementRepository = positionLicenseRequirementRepository;
        }

        public async Task<List<PositionLicenseRequirementListDto>> GetAllAsync()
        {
            var entitiesFromRepo = await _positionLicenseRequirementRepository.GetAllAsync();
            var entitiesToReturn = _mapper.Map<List<PositionLicenseRequirementListDto>>(entitiesFromRepo);
            return entitiesToReturn;
        }

        public async Task<PositionLicenseRequirementListDto> GetByIdAsync(long id)
        {
            var entityFromRepo = await _positionLicenseRequirementRepository.GetByIdAsync(id);
            var entityToReturn = _mapper.Map<PositionLicenseRequirementListDto>(entityFromRepo);
            return entityToReturn;
        }

        public async Task<bool> IsExistNameAsync(string name, long? id = null)
        {
            return await _positionLicenseRequirementRepository.IsExistNameAsync(name, id);
        }

        public async Task<BaseCommandResponse> CreateAsync(CreatePositionLicenseRequirementDto request)
        {
            var response = new BaseCommandResponse();
            var validator = new CreatePositionLicenseRequirementDtoValidator(this);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creating Failed";
                response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
                return response;
            }

            var entity = new PositionLicenseRequirement
            {
                PositionLicenseRequirementName = request.PositionLicenseRequirementName,
                CreatedBy = _currentUserService.UserId,
                CreatedDate = _dateTime.Now
            };
            await _positionLicenseRequirementRepository.CreateAsync(entity);

            response.Success = true;
            response.Message = "Creating Successful";
            return response;
        }

        public async Task<BaseCommandResponse> UpdateAsync(long id, UpdatePositionLicenseRequirementDto request)
        {
            var response = new BaseCommandResponse();
            var validator = new UpdatePositionLicenseRequirementDtoValidator(this);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Updating Failed";
                response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
                return response;
            }

            if (id != request.PositionLicenseRequirementId)
            {
                throw new BadRequestException("Id does not match");
            }

            var entity = await _positionLicenseRequirementRepository.GetByIdAsync(id);

            if (entity is null)
            {
                throw new NotFoundException(nameof(PositionLicenseRequirement), id.ToString());
            }

            entity.PositionLicenseRequirementId = request.PositionLicenseRequirementId;
            entity.PositionLicenseRequirementName = request.PositionLicenseRequirementName;            
            entity.UpdatedBy = _currentUserService.UserId;
            entity.UpdatedDate = _dateTime.Now;
            await _positionLicenseRequirementRepository.UpdateAsync(id, entity);

            response.Success = true;
            response.Message = "Updating Successful";
            return response;
        }

        public async Task<BaseCommandResponse> DeleteAsync(long id)
        {
            var response = new BaseCommandResponse();
            var entity = await _positionLicenseRequirementRepository.GetByIdAsync(id);

            if (entity is null)
            {
                throw new NotFoundException(nameof(PositionLicenseRequirement), id.ToString());
            }

            var result = await _positionLicenseRequirementRepository.DeleteAsync(id);

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
    }
}
