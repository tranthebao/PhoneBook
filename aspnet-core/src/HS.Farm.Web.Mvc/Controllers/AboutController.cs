using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using HS.Farm.Controllers;

namespace HS.Farm.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : FarmControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
