using System.Web.Mvc;

namespace Activity.Web.Controllers
{
    public class HomeController : ActivityControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}