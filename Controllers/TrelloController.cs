using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvancedDevelopment.Models.Trello;
using AdvancedDevelopment.Services;
using Manatee.Trello;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AdvancedDevelopment.Controllers
{
    [Authorize]
    public class TrelloController : Controller
    {
        private readonly TrelloManager _trelloManager;

        public TrelloController(TrelloManager trelloManager) =>
            _trelloManager = trelloManager;

        public async Task <IActionResult> Index()
        {
            await _trelloManager.GetBoard();

            return View("~/Views/Home/Trello/Index.cshtml");
        }

        [HttpGet]
        public IActionResult AddCard()
        {
            var model = new TrelloCard();

            return View("~/Views/Home/Trello/Index.cshtml", model);
        }

        [HttpPost]
        public async Task<IActionResult> PostCard(string cardName, string cardDescription)
        {
            await _trelloManager.AddCard(cardName, cardDescription);

            var cardList = await _trelloManager.GetAllCards();

            var trelloCard = new TrelloCard
            {
                CardCollection = cardList
            };

            return View("~/Views/Home/Trello/ViewCards.cshtml", trelloCard);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var card = await _trelloManager.GetSingleCard(id);

            var model = new TrelloCard
            {
                CardName = card.Name,
                CardDescription = card.Description,
                Id = id
            };

            return View("~/Views/Home/Trello/Edit.cshtml", model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCard(string cardName, string cardDescription, string id)
        {
            _trelloManager.EditCard(id,cardName, cardDescription);

            var cardList = await _trelloManager.GetAllCards();

            var trelloCard = new TrelloCard
            {
                CardCollection = cardList
            };

            return View("~/Views/Home/Trello/ViewCards.cshtml", trelloCard);
        }

        public async Task<IActionResult> ShowCards()
        {
            var cardList = await _trelloManager.GetAllCards();
            
            var trelloCard = new TrelloCard
            {
                CardCollection = cardList
            };

            return View("~/Views/Home/Trello/ViewCards.cshtml", trelloCard);
        }

        public async Task<IActionResult> Delete(string id)
        {
            await _trelloManager.DeleteCard(id);

            var cardList = await _trelloManager.GetAllCards();

            var trelloCard = new TrelloCard
            {
                CardCollection = cardList
            };

            return View("~/Views/Home/Trello/ViewCards.cshtml", trelloCard);
        }
    }
}