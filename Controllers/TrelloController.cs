﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvancedDevelopment.Models.Trello;
using AdvancedDevelopment.Services;
using Manatee.Trello;
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
            var model = new TrelloCard();

            return View("~/Views/Home/Trello/Index.cshtml", model);
        }

        [HttpPost]
        public async Task<IActionResult> PostCard(string cardName, string cardDescription)
        {
            var trelloManager = new TrelloManager();

            await trelloManager.AddCard(cardName, cardDescription);

            var cardList = await trelloManager.GetAllCards();

            var trelloCard = new TrelloCard
            {
                CardCollection = cardList
            };

            return View("~/Views/Home/Trello/ViewCards.cshtml", trelloCard);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var trelloManager = new TrelloManager();
            var card = await trelloManager.GetSingleCard(id);

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
            var trelloManager = new TrelloManager();

            trelloManager.EditCard(id,cardName, cardDescription);

            var cardList = await trelloManager.GetAllCards();

            var trelloCard = new TrelloCard
            {
                CardCollection = cardList
            };

            return View("~/Views/Home/Trello/ViewCards.cshtml", trelloCard);
        }

        public async Task<IActionResult> ShowCards()
        {
            var trelloManager = new TrelloManager();
            var cardList = await trelloManager.GetAllCards();
            
            var trelloCard = new TrelloCard
            {
                CardCollection = cardList
            };

            return View("~/Views/Home/Trello/ViewCards.cshtml", trelloCard);
        }

        public async Task<IActionResult> Delete(string id)
        {
            var trelloManager = new TrelloManager();
            await trelloManager.DeleteCard(id);

            var cardList = await trelloManager.GetAllCards();

            var trelloCard = new TrelloCard
            {
                CardCollection = cardList
            };

            return View("~/Views/Home/Trello/ViewCards.cshtml", trelloCard);
        }
    }
}