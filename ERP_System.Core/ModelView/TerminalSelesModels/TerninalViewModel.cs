using ERP_System_Menagment_Infrastuctor.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_System_Menagment_Core.ModelView.TerminalSelesModels
{
    public class TerninalViewModel
    {
        public decimal TotalSum { get; set; }

        public List<Products> AllSellesProduct = new List<Products>();

    }
}
