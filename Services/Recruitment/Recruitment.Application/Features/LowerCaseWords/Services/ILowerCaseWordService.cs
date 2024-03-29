﻿namespace Recruitment.Application.Features.LowerCaseWords
{
    public interface ILowerCaseWordService
    {
        Task<List<LowerCaseWordListDto>> GetAllAsync();       

        Task<LowerCaseWordListDto> GetByIdAsync(long id);       

        Task<bool> IsExistWordAsync(string word, long? id = null);       

        Task<BaseCommandResponse> CreateAsync(CreateLowerCaseWordDto request);        

        Task<BaseCommandResponse> UpdateAsync(long id, UpdateLowerCaseWordDto request);

        Task<BaseCommandResponse> DeleteAsync(long id);
    }
}
;