using System.Web.Mvc;

namespace CodingCraftHOMod1Ex2Scaffolding.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Indice()
        {
            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}