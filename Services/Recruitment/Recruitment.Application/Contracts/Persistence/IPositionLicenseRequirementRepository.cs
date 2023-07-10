namespace Recruitment.Application.Contracts.Persistence
{
    public interface IPositionLicenseRequirementRepository
    {
        Task<IEnumerable<PositionLicenseRequirement>> GetAllAsync();

        Task<PositionLicenseRequirement> GetByIdAsync(long id);

        Task<bool> IsExistNameAsync(string name, long? id = null);

        Task<int> CreateAsync(PositionLicenseRequirement model);

        Task<bool> UpdateAsync(long id, PositionLicenseRequirement model);

        Task<string> DeleteAsync(long id);
    }
}
