﻿using Microsoft.AspNetCore.Mvc;

namespace MVCAssignment001.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
