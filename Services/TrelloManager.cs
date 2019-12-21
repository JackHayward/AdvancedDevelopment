using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Manatee.Trello;

namespace AdvancedDevelopment.Services
{
    public class TrelloManager
    {

        public TrelloAuthorization Auth = new TrelloAuthorization
        {
            AppKey = "61c67c975cfe95d8089408d20290922c",
            UserToken = "44d910131f7a31dec6ad79491b342a586ed1978344d3e0f64ee8fa81bd2f4bb9"
        };

        public async Task<IBoard> GetBoard()
        {
            var factory = new TrelloFactory();
            var board = factory.Board("xAkpefvd", Auth);

            await board.Refresh();

            return board;
        }

        public async Task AddCard(string cardName)
        {
            var board = GetBoard();
            var backlog = board.Result.Lists.FirstOrDefault(l => l.Name == "Main List");

            if (backlog != null)
            {
                await backlog.Cards.Add(cardName);
            }
        }
    }
}
