using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Manatee.Trello;
using Microsoft.Extensions.Configuration;
using IQueryable = Manatee.Trello.IQueryable;

namespace AdvancedDevelopment.Services
{
    public class TrelloManager
    {
        private const string BoardId = "xAkpefvd";
        private readonly TrelloFactory _trelloFactory;

        public TrelloAuthorization Auth { get; }

        public TrelloManager(IConfiguration configuration)
        {
            _trelloFactory = new TrelloFactory();
            Auth = new TrelloAuthorization
            {
                AppKey = configuration.GetValue<string>("TrelloAppKey"),
                UserToken = configuration.GetValue<string>("TrelloUserToken")
            };
        }

        public async Task<IBoard> GetBoard()
        {
            var factory = _trelloFactory;
            var board = factory.Board(BoardId, Auth);

            await board.Refresh();

            return board;
        }

        public async Task AddCard(string cardName, string cardDescription)
        {
            var board = GetBoard();
            var list = board.Result.Lists.FirstOrDefault(l => l.Name == "Main List");

            if (list != null)
            {
                await list.Cards.Add(cardName, cardDescription, null);
            }
        }

        public void EditCard(string id, string cardName, string cardDescription)
        {
            if (id != null)
            {
                var card = _trelloFactory.Card(id);

                card.Name = cardName;
                card.Description = cardDescription;
            }
        }

        public async Task DeleteCard(string id)
        {
            if (id != null)
            {
                await _trelloFactory.Card(id).Delete();
            }
        }

        public async Task<ICard> GetSingleCard(string id)
        {
            var card = _trelloFactory.Card(id);
            await card.Refresh();

            return card;
        }

        public async Task<ICardCollection> GetAllCards()
        {
            var board = _trelloFactory.Board(BoardId);
            await board.Lists[0].Cards.Refresh();

            var cardList = board.Lists[0].Cards;

            return cardList;
        }
    }
}
