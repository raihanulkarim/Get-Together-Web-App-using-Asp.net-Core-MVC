using GetTogetherApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GetTogetherApp.Controllers
{
    public class HomeController : Controller
    {
 
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult RvspForm()
        {
         
            return View();
        }
        [HttpPost]
        public IActionResult RvspForm(ResponseModel responseModel)
        {
            if (ModelState.IsValid)
            {
                ResponseStore.SaveChanges(responseModel);
                return View("Welcome", responseModel);
            }
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult ContactForm()
        {
            return View();
        }
        public IActionResult ResponseList()
        {
            return View(ResponseStore.Responses.Where(r => r.WillAttend == true));
                 
        }
    }
}
