using System.ComponentModel.DataAnnotations;

namespace BaseApp.Models
{
    public class UnitOfMeasure
    {
        [Required]
        public string? UnitMeasureCode { get; set; }

        public string? Name { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
