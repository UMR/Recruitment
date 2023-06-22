namespace Recruitment.Application.Features.LowerCaseWords
{
    public interface ILowerCaseWordService
    {
        Task<List<LowerCaseWordListDto>> GetAllAsync();       

        Task<LowerCaseWordListDto> GetByIdAsync(long id);       

        Task<bool> IsExistWordAsync(string word, long? id = null);       

        Task<BaseCommandResponse> CreateAsync(CreateUpperCaseWordDto request);        

        Task<BaseCommandResponse> UpdateAsync(long id, UpdateUpperCaseWordDto request);

        Task<BaseCommandResponse> DeleteAsync(long id);
    }
}
;