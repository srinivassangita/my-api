﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvsTaskManager.Controllers
{
  public class HomeController : Controller
  {
    [Route("home/index")]
    public IActionResult Index()
    {
      return View();
    }
  }
}
