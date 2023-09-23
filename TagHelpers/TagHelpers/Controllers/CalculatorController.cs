﻿using Microsoft.AspNetCore.Mvc;

namespace TagHelpers.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public int Add(int x,int y)
        {
            return x +  y;
        }
        public int Sub(int x,int y)
        {
            return x - y;   
        }
    }
}
