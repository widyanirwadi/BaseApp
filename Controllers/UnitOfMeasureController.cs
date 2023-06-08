using BaseApp.Contracts;
using BaseApp.Models;
using BaseApp.Context;
using Microsoft.AspNetCore.Mvc;
/*using Microsoft.EntityFrameworkCore;*/
using Microsoft.AspNetCore.SignalR;

namespace BaseApp.Controllers
{
    [ApiController]
    [Route("UnitOfMeasure")]
    public class UnitOfMeasureController : Controller
    {
        /*
        private readonly string connectionString = "Data Source=JKTITNB07\\SQLEXPRESS;Initial Catalog=AdventureWorks2022;Integrated Security=True; Encrypt=False";

        public IActionResult Index()
        {
            List<UnitOfMeasure> unitOfMeasures = new List<UnitOfMeasure>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT UnitMeasureCode, Name, ModifiedDate FROM Production.UnitMeasure", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UnitOfMeasure unitOfMeasure = new UnitOfMeasure
                            {
                                UnitMeasureCode = reader.GetString(0),
                                Name = reader.GetString(1),
                                ModifiedDate = reader.GetDateTime(2)
                            };

                            unitOfMeasures.Add(unitOfMeasure);
                        }
                    }
                }
            }

            return View(unitOfMeasures);
        }
        */

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
            string[] testing = { "D1", "D2" };
            
            IEnumerable<UnitOfMeasure> unitOfMeasures = await _UnitOfMeasureRepository.GetUnitMeasureByUnitMeasureCode(UnitMeasureCode);
            return Ok(unitOfMeasures);

        }
    }
}
