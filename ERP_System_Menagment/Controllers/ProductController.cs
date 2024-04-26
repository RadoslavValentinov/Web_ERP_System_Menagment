using ERP_System_Menagment_Core.IServices;
using ERP_System_Menagment_Core.ModelView.ProductVievModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ERP_System_Menagment.Controllers
{
    //[Authorize]
    public class ProductController : Controller
    {
        private readonly IProductService service;

        public ProductController(IProductService _service)
        {
            service = _service;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AllProducts()
        {
            var result = await service.AllProducts();
            return View(result);
        }



        [HttpGet]
        public IActionResult CreateProducts() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProducts(ProductViewModel model) 
        {
            return View(model);
        }



        [HttpGet]
        public IActionResult EditProducts()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EditProducts(EditProductViewModel model)
        {
            return View(model);
        }



        public IActionResult DeleteProducts()
        {
            return View();
        }

    }
}
