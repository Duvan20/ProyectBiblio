using Microsoft.AspNetCore.Mvc;

namespace Mvc.Controllers{
    public class HistoryController : Controller{
        public IActionResult Index(){
            return View();
        }

        public IActionResult Delete(){
            return View();
        }

    }

}