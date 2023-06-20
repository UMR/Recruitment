namespace Recruitment.Application.Features.PositionLicenseRequirement
{
    public interface IPositionLicenseRequirementService
    {
        Task<List<PositionLicenseRequirementListDto>> GetPositionLicenseRequirementsAsync();

        Task<PositionLicenseRequirementListDto> GetPositionLicenseRequirementByIdAsync(long id);

        Task<bool> IsExistNameAsync(string name, long? id = null);

        Task<BaseCommandResponse> CreatePositionLicenseRequirementAsync(CreatePositionLicenseRequirementDto request);

        Task<BaseCommandResponse> UpdatePositionLicenseRequirementAsync(long id, UpdatePositionLicenseRequirementDto request);

        Task<BaseCommandResponse> DeletePositionLicenseRequirementAsync(long id);
    }
}
