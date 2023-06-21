﻿namespace Recruitment.Application.Features.SpecialWords;

public interface IUpperCaseWordService
{
    Task<List<UpperCaseWordListDto>> GetAllAsync();

    Task<UpperCaseWordListDto> GetByIdAsync(long id);

    Task<bool> IsExistWordAsync(string name, long? id = null);

    Task<BaseCommandResponse> CreateAsync(CreateSpecialWordDto request);

    Task<BaseCommandResponse> UpdateAsync(long id, UpdateUpperCaseWordDto request);

    Task<BaseCommandResponse> DeleteAsync(long id);
}
