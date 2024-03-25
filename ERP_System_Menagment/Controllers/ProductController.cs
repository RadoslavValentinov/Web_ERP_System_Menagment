using Microsoft.AspNetCore.Mvc;

namespace ERP_System_Menagment.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
