using Business.IBusiness;
using Microsoft.AspNetCore.Mvc;

namespace GoDutchRides.UI.Controllers
{
    
    public class AuthenticationController : Controller
    {
        private readonly IAuthentication _authentication;
        public AuthenticationController(IAuthentication authentication)
        {
            _authentication = authentication;
        }
        [HttpPost]
        public async Task<IActionResult> Login()
        {
            var result = await _authentication.AuthenticateAsync();
           
            return View();
        }
    }
}
