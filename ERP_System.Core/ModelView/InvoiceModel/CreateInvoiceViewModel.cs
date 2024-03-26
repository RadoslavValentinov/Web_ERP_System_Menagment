using ERP_System_Menagment_Infrastuctor.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
