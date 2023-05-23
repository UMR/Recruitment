namespace Recruitment.Application.Features.Agencies
{
    public interface IAgencyService
    {
        Task<List<AgencyListDto>> GetAgencies();

        Task<AgencyListDto> GetAgencyById(int id);

        Task<int> CreateAgency(CreateAgencyDto dto);
    }
}
