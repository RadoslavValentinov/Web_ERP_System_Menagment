using ERP_System_Menagment_Infrastuctor.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace ERP_System_Menagment_Core.ModelView.InvoiceModel
{
    public class CreateInvoiceViewModel
    {

        [Required]
        public DateTime UploadTime { get; set; }

        [Required]
        public string ClientName { get; set; } = null!;

        public List<Products> ProductstoSell { get; set; } = new List<Products>();

        [Required]
        public string UserName { get; set; } = null!;
    }
}
