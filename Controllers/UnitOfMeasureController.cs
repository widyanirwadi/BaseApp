using BaseApp.Contracts;
using BaseApp.Models;
using BaseApp.Context;
using Microsoft.AspNetCore.Mvc;

namespace BaseApp.Controllers
{
    [ApiController]
    [Route("UnitOfMeasure")]
    public class UnitOfMeasureController : Controller
    {
        private readonly IUnitOfMeasureRepository _UnitOfMeasureRepository;
        private readonly DBContext _dbContext;
        public UnitOfMeasureController(IUnitOfMeasureRepository UnitOfMeasureRepository, DBContext dbContext)
        {
            _UnitOfMeasureRepository = UnitOfMeasureRepository;
            _dbContext = dbContext;
        }

        [HttpGet("GetUnitOfMeasure")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<UnitOfMeasure>))]
        public async Task<IActionResult> GetUnitOfMeasure(string UnitMeasureCode)
        {   
            IEnumerable<UnitOfMeasure> unitOfMeasures = await _UnitOfMeasureRepository.GetUnitMeasureByUnitMeasureCode(UnitMeasureCode);
            return Ok(unitOfMeasures);

        }
    }
}
