using ERP_System_Menagment_Core.ModelView.InvoiceModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ERP_System_Menagment.Controllers
{
    [Authorize]
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult CreateInvoice()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateInvoice(CreateInvoiceViewModel model) 
        {
            return View();
        }



        //[HttpGet]
        //public IActionResult EditInvoice()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult EditInvoice(CreateInvoiceViewModel model) 
        //{
        //    return View();
        //}




        public IActionResult DeleteInvoice()
        {
            return View();
        }
    }

}
