using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Entities;
using ProjectManagement.Extentions;

namespace ProjectManagement.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            if (this.HttpContext.Session.GetObject<User>("loggedUser") == null)
            {
                return RedirectToAction("Login", "Home");
            }
            return View();
        }
    }
}
