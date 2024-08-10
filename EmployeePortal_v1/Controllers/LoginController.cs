using EmployeePortal_v1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePortal_v1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ErrorMessage = "";
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Login(LoginViewModel model, string returnurl = null)
        {
            if (ModelState.IsValid && model.UserName=="admin" && model.Password=="admin@123")
            {
                return RedirectToAction("Index", "Home");
            }
            ViewBag.ErrorMessage = "Invalid username or password";
            ModelState.AddModelError("", "Invalid username or password");
            return RedirectToAction("Index", "Login");            
        }
    }
}
