namespace Recruitment.Application.Contracts.Persistence;

public interface IInstitutionTypeRepository
{
    Task<IEnumerable<InstituteTypeTable>> GetInstitutionTypesAsync();

    Task<InstituteTypeTable> GetInstitutionTypeByIdAsync(int id);

    Task<int> CreateInstitutionTypeAsync(InstituteTypeTable instituteType);

    Task<bool> UpdateInstitutionTypeAsync(int id, InstituteTypeTable instituteType);

    Task<bool> DeleteInstitutionTypeAsync(long id);    
    
}
