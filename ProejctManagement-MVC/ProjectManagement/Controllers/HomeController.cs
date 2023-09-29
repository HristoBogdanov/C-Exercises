using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Entities;
using ProjectManagement.Repositories;
using ProjectManagement.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginVM model)
        {
            var context = new ProjectManagementDbContext();
            User loggedUser = context.Users
                .Where(u => u.Username == model.Username && u.Password == model.Password)
                .FirstOrDefault();

            if (loggedUser == null)
                return View();

                this.HttpContext.Session.SetString("loggedUser", model.Username);
                return RedirectToAction("Index","Users");
        }
    }
}
