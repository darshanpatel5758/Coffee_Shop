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
        public IActionResult Form()
        {
            return View();
        }

        public IActionResult FormResult(FormResultViewModel model)
        {
            return View(model);
        }
    }
}
