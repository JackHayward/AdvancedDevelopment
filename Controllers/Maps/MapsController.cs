using System;
using System.Collections.Generic;
using AdvancedDevelopment.Models.Maps;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdvancedDevelopment.Controllers.Maps
{
    public class MapsController : Controller
    {
        [Authorize]
        public ActionResult Index()
            {
                return View("~/Views/Home/Maps/Map.cshtml");
            }
    }
}