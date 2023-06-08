using BaseApp.Models;

namespace BaseApp.Contracts
{
    public interface IProductRepository
    {
        public Task<IEnumerable<Product>> GetProductByKey(int ProductID);
    }
}
