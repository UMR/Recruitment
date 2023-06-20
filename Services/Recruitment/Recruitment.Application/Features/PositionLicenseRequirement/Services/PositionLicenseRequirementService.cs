namespace Recruitment.Application.Features.PositionLicenseRequirement
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
            var emailTypesFromRepo = await _positionLicenseRequirementRepository.GetAllAsync();
            var emailTypesToReturn = _mapper.Map<List<PositionLicenseRequirementListDto>>(emailTypesFromRepo);
            return emailTypesToReturn;
        }

        public async Task<PositionLicenseRequirementListDto> GetByIdAsync(long id)
        {
            var emailTypeFromRepo = await _positionLicenseRequirementRepository.GetByIdAsync(id);
            var emailTypeToReturn = _mapper.Map<PositionLicenseRequirementListDto>(emailTypeFromRepo);
            return emailTypeToReturn;
        }

        public async Task<bool> IsExistAsync(string name, long? id = null)
        {
            return await _positionLicenseRequirementRepository.IsExistAsync(name, id);
        }

        public async Task<BaseCommandResponse> CreateAsync(CreatePositionLicenseRequirementDto request)
        {
            var response = new BaseCommandResponse();
            //var validator = new CreateEmailTypeDtoValidator();
            //var validationResult = await validator.ValidateAsync(request);

            //if (validationResult.IsValid == false)
            //{
            //    response.Success = false;
            //    response.Message = "Creating Failed";
            //    response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
            //    return response;
            //}

            //var entity = new EmailType
            //{
            //    Type = request.Type,
            //    IsPersonal = request.IsPersonal,
            //    IsOfficial = request.IsOfficial,
            //    CreatedBy = _currentUserService.UserId,
            //    CreatedDate = _dateTime.Now
            //};
            //await _emailTypeRepository.CreateEmailTypeAsync(entity);

            response.Success = true;
            response.Message = "Creating Successful";
            return response;
        }

        public async Task<BaseCommandResponse> UpdateAsync(long id, UpdatePositionLicenseRequirementDto request)
        {
            var response = new BaseCommandResponse();
            //var validator = new UpdateEmailTypeDtoValidator(this);
            //var validationResult = await validator.ValidateAsync(request);

            //if (validationResult.IsValid == false)
            //{
            //    response.Success = false;
            //    response.Message = "Updating Failed";
            //    response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
            //    return response;
            //}

            //if (id != request.Id)
            //{
            //    throw new BadRequestException("Id does not match");
            //}

            //var entity = await _emailTypeRepository.GetEmailTypeByIdAsync(id);

            //if (entity is null)
            //{
            //    throw new NotFoundException(nameof(User), id.ToString());
            //}

            //entity.Id = request.Id;
            //entity.Type = request.Type;
            //entity.IsOfficial = request.IsOfficial;
            //entity.IsPersonal = request.IsPersonal;
            //entity.UpdatedBy = _currentUserService.UserId;
            //entity.UpdatedDate = _dateTime.Now;
            //await _emailTypeRepository.UpdateEmailTypeAsync(id, entity);

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
                throw new NotFoundException(nameof(User), id.ToString());
            }

            await _positionLicenseRequirementRepository.DeleteAsync(id);

            response.Success = true;
            response.Message = "Deleting Successful";
            return response;
        }                
    }
}
