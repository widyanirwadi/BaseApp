using BaseApp.Models;

namespace BaseApp.Contracts
{
    public interface IUnitOfMeasureRepository
    {
        public Task<IEnumerable<UnitOfMeasure>> GetUnitMeasureByUnitMeasureCode(string UnitMeasureCode);
        
    }
}
