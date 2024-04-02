using ERP_System_Menagment_Core.ModelView.ClientsModels;
using Microsoft.AspNetCore.Mvc;

namespace ERP_System_Menagment.Controllers
{

    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AllClients() 
        {
            return View();
        }



        [HttpGet]
        public IActionResult CreateClient()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateClient(ClientViewModel model)
        {
            return View(model);
        }



        [HttpGet]
        public IActionResult EditClient(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult EditClient(EditClientsViewModel  model) 
        {
            return View(model);
        }



        public IActionResult DeleteClient()
        {
            return View();
        }
    }
}
