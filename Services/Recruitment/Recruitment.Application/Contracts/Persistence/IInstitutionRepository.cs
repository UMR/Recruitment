namespace Recruitment.Application.Contracts.Persistence;

public interface IInstitutionRepository
{
    Task <bool> GetInstitutionByInstituteTypeIdAsync(int id);
    
}
