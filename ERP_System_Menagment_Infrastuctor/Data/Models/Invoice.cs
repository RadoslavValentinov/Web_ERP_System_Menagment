using System.ComponentModel.DataAnnotations;

namespace ERP_System_Menagment_Infrastuctor.Data.Models
{
    public class Invoice
    {
        [Key]
        public int id { get; set; }

        [Required]
        public DateTime UploadTime { get; set; }

        [Required]
        public string? RecipientCompany { get; set; }

        public List<Products> ProductstoSell { get; set; } = new List<Products>();

        [Required]
        public string UserName { get; set; } = null!;
    }
}
