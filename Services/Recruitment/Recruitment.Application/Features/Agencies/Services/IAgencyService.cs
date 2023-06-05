namespace Recruitment.Application.Features.Agencies;

public interface IAgencyService
{
    Task<List<AgencyListDto>> GetAgenciesAsync();

    Task<AgencyListDto> GetAgencyByIdAsync(int id);

    Task<BaseCommandResponse> CreateAgencyAsync(CreateAgencyDto request);

    Task<BaseCommandResponse> UpdateAgencyAsync(int id, UpdateAgencyDto request);

    Task<BaseCommandResponse> DeleteAgencyAsync(int id);
}
