﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FossilHuntMVC.Controllers
{
    public class QuestionController : Controller
    {




        public IActionResult Index()
        {
            return View();
        }
    }
}
