using System.Web.Mvc;

namespace ABP.SPA.Web.Controllers
{
    public class HomeController : SPAControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}