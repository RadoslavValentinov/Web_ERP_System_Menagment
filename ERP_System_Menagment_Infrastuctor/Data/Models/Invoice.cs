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
        public List<string> RecipientCompany { get; set; } = new List<string>();

        public List<Products> ProductstoSell { get; set; } = new List<Products>();

        [Required]
        public string UserName { get; set; } = null!;
    }
}
