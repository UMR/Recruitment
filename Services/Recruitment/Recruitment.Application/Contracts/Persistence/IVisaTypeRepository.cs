namespace Recruitment.Application.Contracts.Persistence;

public interface IVisaTypeRepository
{
    Task<IEnumerable<VisaType>> GetAllAsync();    

    Task<VisaType> GetByIdAsync(int id);    

    Task<bool> IsExistVisaTypeAsync(string word, int? id = null);    

    Task<int> CreateAsync(VisaType model);

    Task<bool> UpdateAsync(int id, VisaType model);

    Task<bool> DeleteAsync(int id);
   
}
