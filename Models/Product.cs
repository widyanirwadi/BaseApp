using System.ComponentModel.DataAnnotations;

namespace BaseApp.Models
{
    public class Product
    {
        [MaxLength(50)]
        public string? Name { get; set; }

        [MaxLength(25)]
        public string? ProductNumber { get; set; }
        public bool? MakeFlag { get; set; }
        public bool? FinishedGoodsFlag { get; set; }

        [MaxLength(15)]
        public string Color { get; set; }

        public short? SafetyStockLevel { get; set; }
        public short? ReorderPoint { get; set; }
        public decimal? StandardCost { get; set; }
        public decimal? ListPrice { get; set; }

        [MaxLength(5)]
        public string Size { get; set; }

        [MaxLength(3)]
        public string SizeUnitMeasureCode { get; set; }

        [MaxLength(3)]
        public string WeightUnitMeasureCode { get; set; }
        public decimal Weight { get; set; }
        public int? DaysToManufacture { get; set; }

        [MaxLength(2)]
        public string ProductLine { get; set; }

        [MaxLength(2)]
        public string Class { get; set; }

        [MaxLength(2)]
        public string Style { get; set; }
        public int ProductSubcategoryID { get; set; }
        public int ProductModelID { get; set; }
        public DateTime? SellStartDate { get; set; }
        public DateTime SellEndDate { get; set; }
        public DateTime DiscontinuedDate { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }




    }
}
