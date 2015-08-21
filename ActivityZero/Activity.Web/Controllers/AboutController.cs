using System.Web.Mvc;

namespace Activity.Web.Controllers
{
    public class AboutController : ActivityControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}