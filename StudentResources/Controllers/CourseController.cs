﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StudentResources.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Course()
        {
            return View();
        }
    }
}