using System.ComponentModel.DataAnnotations;

namespace ERP_System_Menagment_Core.ModelView.ProductVievModel
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal SalePrice { get; set; }

        [Required]
        public decimal GoodPrice { get; set; }

    }
}
