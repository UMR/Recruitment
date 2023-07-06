namespace Recruitment.Application.Features.Languages;

public interface ILanguageService
{
    Task<List<LanguageListDto>> GetAllAsync();    

    Task<LanguageListDto> GetByIdAsync(int id);
   
    Task<bool> IsExistLanguageAsync(string name, int? id = null);
    
    Task<BaseCommandResponse> CreateAsync(CreateLanguageDto request);    

    Task<BaseCommandResponse> UpdateAsync(int id, UpdateLanguageDto request);    

    Task<BaseCommandResponse> DeleteAsync(int id);
    
}
