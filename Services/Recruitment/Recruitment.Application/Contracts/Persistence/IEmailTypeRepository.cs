namespace Recruitment.Application.Contracts.Persistence;

public interface IEmailTypeRepository
{
    Task<IEnumerable<EmailType>> GetEmailTypesAsync();

    Task<EmailType> GetEmailTypeByIdAsync(int id);

    Task<int> CreateEmailTypeAsync(EmailType emailType);

    Task<bool> UpdateEmailTypeAsync(int id, EmailType emailType);

    Task<bool> DeleteEmailTypeAsync(long id);    
    
}
