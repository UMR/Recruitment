namespace Recruitment.Application.Features.ManageRecruiter
{
    public interface IRecruiterService
    {
        Task<List<RecruiterListDto>> GetAllRecruitersAsync();

        Task<RecruiterListDto> GetRecruiterByIdAsync(int id);

        Task<BaseCommandResponse> CreateRecruiterAsync(CreateRecruiterDto request);        

        Task<BaseCommandResponse> UpdateRecruiterAsync(int id, UpdateRecruiterDto request);

        Task<BaseCommandResponse> DeleteRecruiterAsync(int deleteUserId, int updatedUserId);
    }
}