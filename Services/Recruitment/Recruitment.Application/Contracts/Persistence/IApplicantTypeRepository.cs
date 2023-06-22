namespace Recruitment.Application.Contracts.Persistence;

public interface IApplicantTypeRepository
{
    Task<IEnumerable<ApplicantTypeEntity>> GetAllAsync();

    Task<ApplicantTypeEntity> GetByIdAsync(int id);

    Task<bool> IsExistAsync(string applicantType, int? id = null);

    Task<int> CreateAsync(ApplicantTypeEntity applicantType);

    Task<bool> UpdateAsync(int id, ApplicantTypeEntity applicantType);

    Task<bool> DeleteAsync(long id);    
    
}
