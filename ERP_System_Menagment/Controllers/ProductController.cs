using ERP_System_Menagment_Core.IServices;
using ERP_System_Menagment_Core.ModelView.ProductVievModel;
using ERP_System_Menagment_Infrastuctor.Data.Models;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Web.Mvc;
using JsonResult = Microsoft.AspNetCore.Mvc.JsonResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;
using HttpGetAttribute = System.Web.Mvc.HttpGetAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;

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

        //method get to data format in Json
       
        public  JsonResult AllProduct()
        {
            var convert = service.AllProducts();

            return Json(convert, JsonRequestBehavior.AllowGet);
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
