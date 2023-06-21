namespace Recruitment.Application.Contracts.Persistence;

public interface IApplicantTypeRepository
{
    Task<IEnumerable<ApplicantType>> GetAllAsync();

    Task<ApplicantType> GetByIdAsync(int id);

    Task<bool> IsExistAsync(string applicantType, int? id = null);

    Task<int> CreateAsync(ApplicantType applicantType);

    Task<bool> UpdateAsync(int id, ApplicantType applicantType);

    Task<bool> DeleteAsync(long id);    
    
}
