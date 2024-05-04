using Business.IBusiness;
using Microsoft.AspNetCore.Mvc;

namespace GoDutchRides.UI.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthentication _authentication;
        public AuthController(IAuthentication authentication)
        {
            _authentication = authentication;    
        }
        public async Task<IActionResult> Test()
        {
            await _authentication.AuthenticateAsync();
            return View();
        }
    }
}
