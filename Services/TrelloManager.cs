using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Manatee.Trello;
using IQueryable = Manatee.Trello.IQueryable;

namespace AdvancedDevelopment.Services
{
    public class TrelloManager
    {
        private const string BoardId = "xAkpefvd";
        private readonly TrelloFactory _trelloFactory;

        public TrelloAuthorization Auth = new TrelloAuthorization
        {
            AppKey = "61c67c975cfe95d8089408d20290922c",
            UserToken = "44d910131f7a31dec6ad79491b342a586ed1978344d3e0f64ee8fa81bd2f4bb9",
        };

        public TrelloManager()
        {
            _trelloFactory = new TrelloFactory();
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

        public async Task DeleteCard(string id)
        {
            var factory = _trelloFactory;

            if (id != null)
            {
                await factory.Card(id).Delete();
            }
        }

        public async Task<ICardCollection> GetCards()
        {
            var board = _trelloFactory.Board(BoardId);
            await board.Lists[0].Cards.Refresh();

            var cardList = board.Lists[0].Cards;

            return cardList;
        }
    }
}
