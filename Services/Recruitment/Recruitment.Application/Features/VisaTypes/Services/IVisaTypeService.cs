namespace Recruitment.Application.Features.VisaTypes;

public interface IVisaTypeService
{
    Task<List<VisaTypeListDto>> GetAllAsync();
    
    Task<VisaTypeListDto> GetByIdAsync(int id);

    Task<bool> IsExistVisaTypeAsync(string visatType, int? id = null);
   
    Task<BaseCommandResponse> CreateAsync(CreateVisaTypeDto request);
    
    Task<BaseCommandResponse> UpdateAsync(int id, UpdateVisaTypeDto request);  

    Task<BaseCommandResponse> DeleteAsync(int id);
    
}
