﻿namespace Recruitment.Persistence.Repositories;

public class ApplicantTypeRepository : IApplicantTypeRepository
{
    private readonly IDapperContext _dapperContext;

    public ApplicantTypeRepository(IDapperContext dapperContext)
    {
        _dapperContext = dapperContext;
    }

    public async Task<IEnumerable<ApplicantTypeEntity>> GetAllAsync()
    {
        var query = @"SELECT * FROM ApplicantType ORDER BY Name ASC";

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var ApplicantTypes = await conn.QueryAsync<ApplicantTypeEntity>(query);
            return ApplicantTypes.ToList();
        }
    }

    public async Task<ApplicantTypeEntity> GetByIdAsync(int id)
    {
        var query = @"SELECT * FROM ApplicantType WHERE ApplicantTypeID=@ID";

        var parameters = new DynamicParameters();
        parameters.Add("ID", id, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var ApplicantType = await conn.QueryFirstOrDefaultAsync<ApplicantTypeEntity>(query, parameters);
            return ApplicantType;
        }
    }

    public async Task<bool> IsExistAsync(string applicantType, int? id = null)
    {
        var query = @"SELECT COUNT(*) FROM ApplicantType WHERE ApplicantTypeID=@ApplicantTypeId";

        if (id != null)
        {
            query += " AND ID != @ApplicantTypeId";
        }

        var parameters = new DynamicParameters();
        parameters.Add("ApplicantTypeId", applicantType, DbType.String);

        if (id is not null)
        {
            parameters.Add("ApplicantTypeId", id, DbType.Int32);
        }

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.ExecuteScalarAsync<int>(query, parameters);
            return result > 0 ? true : false;
        }
    }

    public async Task<int> CreateAsync(ApplicantTypeEntity model)
    {
        var query = "INSERT INTO ApplicantType (Name,  CreatedBy, CreatedDate) VALUES (@Name, @CreatedBy, @CreatedDate) " +
                    "SELECT CAST(SCOPE_IDENTITY() as int)";

        var parameters = new DynamicParameters();
        parameters.Add("Name", model.Name, DbType.String);
        parameters.Add("CreatedBy", model.CreatedBy, DbType.Int32);
        parameters.Add("CreatedDate", model.CreatedDate, DbType.DateTime);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var id = await conn.ExecuteAsync(query, parameters);
            return id;
        }
    }

    public async Task<bool> UpdateAsync(int id, ApplicantTypeEntity model)
    {
        var query = "UPDATE ApplicantType SET Name = @Name, UpdatedBy = @UpdatedBy, UpdatedDate = @UpdatedDate WHERE ApplicantTypeID = @ID";

        var parameters = new DynamicParameters();
        parameters.Add("Name", model.Name, DbType.String);
        parameters.Add("UpdatedBy", model.UpdatedBy, DbType.Int32);
        parameters.Add("UpdatedDate", model.UpdatedDate, DbType.DateTime);
        parameters.Add("ID", id, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.ExecuteAsync(query, parameters);
            return result > 0 ? true : false;
        }
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var query = "DELETE FROM ApplicantType WHERE ApplicantTypeID = @ID";

        var parameters = new DynamicParameters();
        parameters.Add("ID", id, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.ExecuteAsync(query, parameters);
            return result > 0 ? true : false;
        }
    }
}
