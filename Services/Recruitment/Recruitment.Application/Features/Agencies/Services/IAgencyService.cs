namespace Recruitment.Application.Features.Agencies;

public interface IAgencyService
{
    Task<List<AgencyListDto>> GetAgencies();

    Task<AgencyListDto> GetAgencyById(int id);

    Task<BaseCommandResponse> CreateAgency(CreateAgencyDto request);

    Task<BaseCommandResponse> UpdateAgency(int id, UpdateAgencyDto request);

    Task<BaseCommandResponse> DeleteAgency(int id);
}
