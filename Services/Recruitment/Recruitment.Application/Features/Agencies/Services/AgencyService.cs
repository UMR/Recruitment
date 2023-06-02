using Recruitment.Application.Wrapper;

namespace Recruitment.Application.Features.Agencies
{
    public class AgencyService : IAgencyService
    {
        private readonly IMapper _mapper;
        private readonly IAgencyRepository _agencyRepository;

        public AgencyService(IMapper mapper, IAgencyRepository agencyRepository)
        {
            _mapper = mapper;
            _agencyRepository = agencyRepository;
        }

        public async Task<List<AgencyListDto>> GetAgencies()
        {            
            var agenciesFromRepo = await _agencyRepository.GetAgencies();
            var agenciesToReturn = _mapper.Map<List<AgencyListDto>>(agenciesFromRepo);
            return agenciesToReturn;
        }

        public async Task<AgencyListDto> GetAgencyById(int id)
        {
            var agencyFromRepo = await _agencyRepository.GetAgencyById(id);
            var agencyToReturn = _mapper.Map<AgencyListDto>(agencyFromRepo);
            return agencyToReturn;
        }

        public async Task<BaseCommandResponse> CreateAgency(CreateAgencyDto request)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateAgencyDtoValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creating Failed";
                response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
                return response;
            }


            var agencyToCreate = _mapper.Map<Agency>(request);
            await _agencyRepository.CreateAgency(agencyToCreate);

            response.Success = true;
            response.Message = "Creating Successful";            

            return response;
        }

        public async Task<BaseCommandResponse> UpdateAgency(int id, UpdateAgencyDto request) 
        {
            var response = new BaseCommandResponse();
            var validator = new UpdateAgencyDtoValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Updating Failed";
                response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
                return response;
            }

            var agencyToUpdate = await _agencyRepository.GetAgencyById(id);
            
            if (agencyToUpdate is null)
            {
                throw new NotFoundException(nameof(User), id.ToString());
            }

            _mapper.Map(request, agencyToUpdate);
            await _agencyRepository.UpdateAgency(id, agencyToUpdate);

            response.Success = true;
            response.Message = "Updating Successful";

            return response;
        }
    }
}
