namespace Recruitment.Application.Features.UpperCaseWords;

public interface IUpperCaseWordService
{
    Task<List<UpperCaseWordListDto>> GetAllAsync();

    Task<UpperCaseWordListDto> GetByIdAsync(long id);

    Task<bool> IsExistWordAsync(string name, long? id = null);

    Task<BaseCommandResponse> CreateAsync(CreateUpperCaseWordDto request);

    Task<BaseCommandResponse> UpdateAsync(long id, UpdateUpperCaseWordDto request);

    Task<BaseCommandResponse> DeleteAsync(long id);
}
