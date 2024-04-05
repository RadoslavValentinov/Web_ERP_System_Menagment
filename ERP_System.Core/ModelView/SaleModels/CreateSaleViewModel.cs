using ERP_System_Menagment_Infrastuctor.Data.Models;

namespace ERP_System_Menagment_Core.ModelView.SaleModels
{
    public class CreateSaleViewModel
    {

        public int Id { get; set; }

        public DateTime SellTime { get; set; }

        public List<Products> Products { get; set; } = new List<Products>();

        public string UsercCreate { get; set; } = null!;

    }
}
