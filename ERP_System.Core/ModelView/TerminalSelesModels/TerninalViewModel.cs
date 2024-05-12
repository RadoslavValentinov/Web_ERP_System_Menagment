using ERP_System_Menagment_Infrastuctor.Data.Models;

namespace ERP_System_Menagment_Core.ModelView.TerminalSelesModels
{
    public class TerninalViewModel
    {
        public decimal TotalSum { get; set; }

        public List<Products> AllSellesProduct = new List<Products>();

    }
}
