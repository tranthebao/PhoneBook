using Microsoft.AspNetCore.Antiforgery;
using HS.Farm.Controllers;

namespace HS.Farm.Web.Host.Controllers
{
    public class AntiForgeryController : FarmControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
