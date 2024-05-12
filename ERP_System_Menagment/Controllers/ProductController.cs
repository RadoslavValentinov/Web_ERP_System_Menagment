using ERP_System_Menagment.Infrastructure.Data.Common;
using ERP_System_Menagment_Core.IServices;
using ERP_System_Menagment_Core.ModelView.ProductVievModel;
using ERP_System_Menagment_Infrastuctor.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Controller = Microsoft.AspNetCore.Mvc.Controller;
using HttpGetAttribute = System.Web.Mvc.HttpGetAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using JsonResult = Microsoft.AspNetCore.Mvc.JsonResult;

namespace ERP_System_Menagment.Controllers
{
    //[Authorize]
    public class ProductController : Controller
    {
        private readonly IProductService service;
        private readonly IRepository repo;

        public ProductController(IProductService _service,
             IRepository _repo)
        {
            service = _service;
            repo = _repo;
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

        //method get to data format in Json


        /// <summary>
        /// Get All product list of database of json format to send data to div
        /// </summary>
        /// <returns>json data</returns>
        public JsonResult AllProduct()
        {
            var convert = repo.All<Products>();

            return Json(convert);
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
