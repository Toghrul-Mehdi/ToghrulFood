﻿using Microsoft.AspNetCore.Mvc;

namespace Restaurant.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
