namespace Recruitment.Application.Features.InstitutionTypes
{
    public interface IInstitutionTypeService
    {
        Task<List<InstitutionTypeListDto>> GetInstitutionTypesAsync();

        Task<InstitutionTypeListDto> GetInstitutionTypeByIdAsync(int id);        

        Task<BaseCommandResponse> CreateInstitutionTypeAsync(CreateInstitutionTypeDto request);        

        Task<BaseCommandResponse> UpdateInstitutionTypeAsync(int id, UpdateInstitutionTypeDto request);

        Task<BaseCommandResponse> DeleteInstitutionTypeAsync(int id);
    }
}