namespace Recruitment.Application.Contracts.Persistence;

public interface IEmailTypeRepository
{
    Task<IEnumerable<EmailType>> GetAllAsync();

    Task<EmailType> GetByIdAsync(int id);

    Task<bool> IsExistAsync(string emailType, int? id = null);

    Task<int> CreateAsync(EmailType emailType);

    Task<bool> UpdateAsync(int id, EmailType emailType);

    Task<bool> DeleteAsync(long id);    
    
}
