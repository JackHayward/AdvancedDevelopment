using System;
using System.Collections.Generic;
using AdvancedDevelopment.Models.Maps;
using Microsoft.AspNetCore.Mvc;

namespace AdvancedDevelopment.Controllers.Maps
{
    public class MapsController : Controller
    {
        public ActionResult Index()
            {
                var cities = new List<City>();
                cities.Add(new City() { Title = "Paris", Lat = 48.855901, Lng = 2.349272 });
                cities.Add(new City() { Title = "Berlin", Lat = 52.520413, Lng = 13.402794 });
                cities.Add(new City() { Title = "Rome", Lat = 41.907074, Lng = 12.498474 });
                return View("~/Views/Home/Maps/Map.cshtml", cities);
            }
    }
}