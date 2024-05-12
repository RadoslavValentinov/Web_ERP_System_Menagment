using System.ComponentModel.DataAnnotations;

namespace ERP_System_Menagment_Infrastuctor.Data.Models
{
    public class Products
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        public decimal SalePrice { get; set; }


        [Required]
        public decimal GoodPrice { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
