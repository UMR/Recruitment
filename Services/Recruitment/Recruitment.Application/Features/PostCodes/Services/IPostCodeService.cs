namespace Recruitment.Application.Features.PostCodes
{
    public interface IPostCodeService
    {
        Task<BaseCommandResponse> DeleteAsync(int id);
        Task<List<PostCodeListDto>> GetAllAsync();
        Task<PostCodeListDto> GetByIdAsync(int id);
        Task<bool> IsExistPostCodeAsync(string name, int? id = null);
    }
}