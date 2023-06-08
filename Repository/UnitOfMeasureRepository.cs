using Dapper;
using BaseApp.Context;
using BaseApp.Contracts;
using BaseApp.Models;
using System.Data;

namespace BaseApp.Repository
{
    public class UnitOfMeasureRepository : IUnitOfMeasureRepository
    {
        private readonly DBContext _dbContext;
        public UnitOfMeasureRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<UnitOfMeasure>> GetUnitMeasureByUnitMeasureCode(string UnitMeasureCode)
        {
            using (var connection = _dbContext.CreateConnection())
            {
                const string storedProcedure = "dbo.GetUnitMeasureByUnitMeasureCode";
                return await connection.QueryAsync<UnitOfMeasure>(storedProcedure,
                new
                {
                    UnitMeasureCode
                },
                    commandType: CommandType.StoredProcedure);
            }
            
        }

    }
}
