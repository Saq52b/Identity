using IdentityASP.NET_Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IdentityASP.NET_Core.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Register() { 
             RegisterViewModel registerViewModel=new RegisterViewModel();
            return View(registerViewModel);
        }
    }
}
