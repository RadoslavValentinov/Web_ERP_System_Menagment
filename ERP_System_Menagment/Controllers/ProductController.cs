using ERP_System_Menagment.Infrastructure.Data.Common;
using ERP_System_Menagment_Core.IServices;
using ERP_System_Menagment_Core.ModelView.ProductVievModel;
using ERP_System_Menagment_Infrastuctor.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;
using Controller = Microsoft.AspNetCore.Mvc.Controller;
using HttpGetAttribute = System.Web.Mvc.HttpGetAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using JsonResult = Microsoft.AspNetCore.Mvc.JsonResult;
using System.Text.Json;

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





        /// <summary>
        /// Get All product from database and load in view
        /// </summary>
        /// <returns>all product from database</returns>
        [HttpGet]
        public async Task<IActionResult> AllProducts()
        {
            var result = await service.AllProducts();
            return View(result);
        }




        //method get to data format in Json

        [HttpPost]
        /// <summary>
        /// Get All product list of database of json format to send data to div of autocomplete menu
        /// </summary>
        /// <returns>json data</returns>
        public JsonResult AllProduct(string term)
        {
            var convert = repo.All<Products>().Where(x => x.Name.ToLower().StartsWith(term.ToLower()));

            return Json(convert);

        }


        /// <summary>
        /// Loading form of create product 
        /// </summary>
        /// <returns>form</returns>
        [HttpGet]
        public IActionResult CreateProducts()
        {
            return View();
        }

        /// <summary>
        /// Send all info of form and create new product 
        /// and add new product in database
        /// </summary>
        /// <param name="model"></param>
        /// <returns>If operation succssessfuly redirect to all product view page</returns>
        [HttpPost]
        public async Task<IActionResult> CreateProducts(ProductViewModel model)
        {
            await service.CreateProduct(model);

            return RedirectToAction("AllProducts");
        }




        /// <summary>
        ///Get the id of the current product.Find the 
        ///product in the database and populate the model 
        ///with the product data.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>А new EditProductViewModel containing the product data.</returns>
        [HttpGet]
        public IActionResult EditProducts(int Id)
        {
            var result = repo.GetByIdAsync<Products>(Id).Result;

            var model = new EditProductViewModel()
            {
                Id = result.ID,
                Name = result.Name,
                Quantity = result.Quantity,
                SalePrice = result.SalePrice,
                GoodPrice = result.GoodPrice
            };

            return View(model);
        }




        /// <summary>
        ///  The method updates the information of 
        ///  the product selected by the user.
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Update product in Allproduct view</returns>
        [HttpPost]
        public async Task<IActionResult> EditProducts(EditProductViewModel model)
        {
            await service.EditProducts(model);

            return RedirectToAction("AllProducts");
        }



        /// <summary>
        /// Delete product by model
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Redirect page to All product</returns>
        public async Task<IActionResult> DeleteProducts(ProductViewModel model)
        {
            await service.DeleteProduct(model);

            return RedirectToAction("AllProducts");
        }

    }
}
