namespace Recruitment.Application.Features.EmailTypes
{
    public interface IEmailTypeService
    {
        Task<List<EmailTypeListDto>> GetAllAsync();

        Task<EmailTypeListDto> GetByIdAsync(int id);

        Task<bool> IsExistAsync(string emailType, int? id = null);

        Task<BaseCommandResponse> CreateAsync(CreateEmailTypeDto request);        

        Task<BaseCommandResponse> UpdateAsync(int id, UpdateEmailTypeDto request);

        Task<BaseCommandResponse> DeleteAsync(int id);
    }
}