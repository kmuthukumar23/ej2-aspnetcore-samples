﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EJ2CoreSampleBrowser.Models;

namespace EJ2CoreSampleBrowser.Controllers.HeatMap
{
    public partial class HeatMapController : Controller
    {
        public IActionResult RenderMode()
        {
            ViewBag.dataSource = new HeatMapData().GetRendermodeData();
            return View();
        }
    }
}