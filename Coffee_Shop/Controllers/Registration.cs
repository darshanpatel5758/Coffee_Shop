using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coffee_Shop.Models.Registration;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult RegistrationForm()
        {
            return View();
        }

        public IActionResult FormView(RegistrationViewModel model)
        {
            return View(model);
        }
    }
}
