using ERP_System_Menagment_Core.ModelView.SaleModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ERP_System_Menagment.Controllers
{
  
    public class SaleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult CreateSale()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSale(CreateSaleViewModel model)
        {
            return View(model);
        }

    }
}
