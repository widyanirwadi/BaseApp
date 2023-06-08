using Dapper;
using BaseApp.Context;
using BaseApp.Contracts;
using BaseApp.Models;
using System.Data;

namespace BaseApp.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DBContext _dbContext;
        public ProductRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Product>> GetProductByKey(int ProductID)
        {
            using (var connection = _dbContext.CreateConnection())
            {
                const string storedProcedure = "dbo.GetProductByKey";
                return await connection.QueryAsync<Product>(storedProcedure,
                new
                {
                    ProductID
                },
                    commandType: CommandType.StoredProcedure);
            }

        }
    }
}
