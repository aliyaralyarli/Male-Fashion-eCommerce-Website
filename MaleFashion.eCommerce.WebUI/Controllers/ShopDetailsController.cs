﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaleFashion.eCommerce.WebUI.Controllers
{
    public class ShopDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}