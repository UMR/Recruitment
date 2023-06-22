using Recruitment.Application.Features.ManageRecruiter;

namespace Recruitment.Application.Contracts.Persistence;

public interface IRecruiterRepository
{
    Task<IEnumerable<RecruiterListDto>> GetAllRecruitersAsync();
    Task<IEnumerable<RecruiterListDto>> GetAllRecruitersByAsync(SearchRecruiterParamDto searchRecruiterParamDto);

    Task<User> GetRecruiterByIdAsync(int id);

    Task<int> CreateRecruiterAsync(User user);

    Task<bool> UpdateRecruiterAsync(int id, User user);

    Task<bool> DeleteRecruiterAsync(int deleteUserId, int updatedUserId);    
    
}
