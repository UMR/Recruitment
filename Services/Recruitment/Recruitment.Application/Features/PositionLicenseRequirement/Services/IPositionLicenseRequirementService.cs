namespace Recruitment.Application.Features.PositionLicenseRequirement
{
    public interface IPositionLicenseRequirementService
    {
        Task<List<PositionLicenseRequirementListDto>> GetAllAsync();

        Task<PositionLicenseRequirementListDto> GetByIdAsync(long id);

        Task<bool> IsExistAsync(string name, long? id = null);

        Task<BaseCommandResponse> CreateAsync(CreatePositionLicenseRequirementDto request);

        Task<BaseCommandResponse> UpdateAsync(long id, UpdatePositionLicenseRequirementDto request);

        Task<BaseCommandResponse> DeleteAsync(long id);
    }
}
