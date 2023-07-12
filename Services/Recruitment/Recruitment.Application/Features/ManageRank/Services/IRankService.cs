namespace Recruitment.Application.Features.ManageRank
{
    public interface IRankService
    {
        Task<List<RankListDto>> GetAllAsync();
        Task<RankListDto> GetByIdAsync(int id);
    }
}