namespace Recruitment.Application.Features.Agencies.Services
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

        public async Task<int> CreateAgency(CreateAgencyDto request)
        {
            var agency = new Domain.Entities.Agency();
            agency.AgencyName = request.AgencyName;
            agency.CreatedBy = request.CreatedBy;
            agency.CreatedDate = DateTime.Now;
            return await _agencyRepository.CreateAgency(agency);
        }
    }
}
