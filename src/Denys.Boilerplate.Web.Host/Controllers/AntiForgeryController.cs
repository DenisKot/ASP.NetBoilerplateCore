using Microsoft.AspNetCore.Antiforgery;
using Denys.Boilerplate.Controllers;

namespace Denys.Boilerplate.Web.Host.Controllers
{
    public class AntiForgeryController : BoilerplateControllerBase
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
