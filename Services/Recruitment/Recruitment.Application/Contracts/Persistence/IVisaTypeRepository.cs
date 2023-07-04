namespace Recruitment.Application.Contracts.Persistence;

public interface IVisaTypeRepository
{
    Task<IEnumerable<VisaTypeEntity>> GetAllAsync();    

    Task<VisaTypeEntity> GetByIdAsync(int id);    

    Task<bool> IsExistVisaTypeAsync(string word, int? id = null);    

    Task<int> CreateAsync(VisaTypeEntity model);

    Task<bool> UpdateAsync(int id, VisaTypeEntity model);

    Task<bool> DeleteAsync(int id);
   
}
