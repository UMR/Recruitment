namespace Recruitment.Application.Features.SpecialWords;

public interface ISpecialWordService
{
    Task<List<SpecialWordListDto>> GetAllAsync();

    Task<SpecialWordListDto> GetByIdAsync(long id);

    Task<bool> IsExistWordAsync(string name, long? id = null);

    Task<BaseCommandResponse> CreateAsync(CreateSpecialWordDto request);

    Task<BaseCommandResponse> UpdateAsync(long id, UpdateSpecialWordDto request);

    Task<BaseCommandResponse> DeleteAsync(long id);
}
