﻿using ERP_System_Menagment_Core.ModelView.ProductVievModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ERP_System_Menagment.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AllProducts()
        {
            return View();
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
