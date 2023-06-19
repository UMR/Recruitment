namespace Recruitment.Application.Features.EmailTypes
{
    public interface IEmailTypeService
    {
        Task<List<EmailTypeListDto>> GetEmailTypesAsync();

        Task<EmailTypeListDto> GetEmailTypeByIdAsync(int id);

        Task<bool> IsExistEmailTypeAsync(string emailType, int? id = null);

        Task<BaseCommandResponse> CreateEmailTypeAsync(CreateEmailTypeDto request);        

        Task<BaseCommandResponse> UpdateEmailTypeAsync(int id, UpdateEmailTypeDto request);

        Task<BaseCommandResponse> DeleteEmailTypeAsync(int id);
    }
}