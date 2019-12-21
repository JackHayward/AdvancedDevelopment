using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvancedDevelopment.Models.Trello;
using AdvancedDevelopment.Services;
using Microsoft.AspNetCore.Mvc;

namespace AdvancedDevelopment.Controllers
{
    public class TrelloController : Controller
    {
        public async Task <IActionResult> Index()
        {
            var trelloManager = new TrelloManager();

            await trelloManager.GetBoard();

            return View("~/Views/Home/Trello/Index.cshtml");
        }

        [HttpGet]
        public IActionResult AddCard()
        {
            var model = new Trello();

            return View("~/Views/Home/Trello/Index.cshtml", model);
        }

        [HttpPost]
        public async Task<IActionResult> PostCard(string cardName)
        {
            var trelloManager = new TrelloManager();

            await trelloManager.AddCard(cardName);

            return View("~/Views/Home/Trello/Index.cshtml");
        }
    }
}