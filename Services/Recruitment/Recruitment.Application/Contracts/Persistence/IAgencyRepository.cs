﻿namespace Recruitment.Application.Contracts.Persistence;

public interface IAgencyRepository
{
    Task<IEnumerable<Agency>> GetAgenciesAsync();

    Task<Agency> GetAgencyByIdAsync(long id);

    bool IsExistAgencyNameAsync(string agencyName);

    Task<int> CreateAgencyAsync(Agency agency);

    Task<bool> UpdateAgencyAsync(long id,Agency agency);

    Task<bool> DeleteAgencyAsync(long agency);
}
