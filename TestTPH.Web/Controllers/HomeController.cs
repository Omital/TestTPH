using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace TestTPH.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TestTPHControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}