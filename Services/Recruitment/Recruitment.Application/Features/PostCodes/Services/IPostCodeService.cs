namespace Recruitment.Application.Features.PostCodes
{
    public interface IPostCodeService
    {
        Task<List<PostCodeListDto>> GetAllAsync();

        Task<PostCodeListDto> GetByIdAsync(int id);

        Task<bool> IsExistPostCodeAsync(string name, int? id = null);

        Task<BaseCommandResponse> CreateAsync(CreatePostCodeDto request);

        Task<BaseCommandResponse> UpdateAsync(int id, UpdatePostCodeDto request);

        Task<BaseCommandResponse> DeleteAsync(int id);

    }
}