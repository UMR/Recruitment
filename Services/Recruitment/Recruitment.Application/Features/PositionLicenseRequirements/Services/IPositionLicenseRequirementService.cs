namespace Recruitment.Application.Features.PositionLicenseRequirements
{
    public interface IPositionLicenseRequirementService
    {
        Task<List<PositionLicenseRequirementListDto>> GetAllAsync();

        Task<PositionLicenseRequirementListDto> GetByIdAsync(long id);

        Task<bool> IsExistNameAsync(string name, long? id = null);

        Task<BaseCommandResponse> CreateAsync(CreatePositionLicenseRequirementDto request);

        Task<BaseCommandResponse> UpdateAsync(long id, UpdatePositionLicenseRequirementDto request);

        Task<BaseCommandResponse> DeleteAsync(long id);
    }
}
