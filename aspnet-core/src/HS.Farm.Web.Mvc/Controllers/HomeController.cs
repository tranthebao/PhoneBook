using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using HS.Farm.Controllers;

namespace HS.Farm.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : FarmControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
