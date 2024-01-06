using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Book.Controllers
{
    public class LoginController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new LoginViewModel
            {
                Username = "",
                Password = ""
            };

            return View(model);
        }


        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Handle registration logic here
                // For simplicity, let's assume a successful registration for now
                return RedirectToAction("Index", "Home"); // Redirect to the home page
            }

            // If the model is not valid, return to the registration page with errors
            return View(model);
        }
    }
}

