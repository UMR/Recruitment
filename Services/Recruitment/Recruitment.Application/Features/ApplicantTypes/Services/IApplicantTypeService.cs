namespace Recruitment.Application.Features.ApplicantType
{
    public interface IApplicantTypeService
    {
        Task<List<ApplicantTypeEntity>> GetAllAsync();

        Task<ApplicantTypeListDto> GetByIdAsync(int id);

        Task<bool> IsExistAsync(string applicantType, int? id = null);

        Task<BaseCommandResponse> CreateAsync(CreateApplicantTypeDto request);        

        Task<BaseCommandResponse> UpdateAsync(int id, UpdateApplicantTypeDto request);

        Task<BaseCommandResponse> DeleteAsync(int id);
    }
}