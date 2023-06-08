namespace Recruitment.Application.Features.Agencies;

public interface IAgencyService
{
    Task<List<AgencyListDto>> GetAgenciesAsync();

    Task<AgencyListDto> GetAgencyByIdAsync(long id);

    Task<bool> IsExistAgencyNameAsync(string agencyName, long? id = null);

    Task<BaseCommandResponse> CreateAgencyAsync(CreateAgencyDto request);

    Task<BaseCommandResponse> UpdateAgencyAsync(long id, UpdateAgencyDto request);

    Task<BaseCommandResponse> UpdateAgencyStatusAsync(long id, UpdateAgencyStatusDto request);

    Task<BaseCommandResponse> DeleteAgencyAsync(long id);
}
