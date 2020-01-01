using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvancedDevelopment.Areas.Identity.Data;
using AdvancedDevelopment.Models.GameViewer;
using AdvancedDevelopment.Models.ViewModels;
using Google.Cloud.Datastore.V1;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SendGrid.Helpers.Mail;
using Enum = System.Enum;


namespace AdvancedDevelopment.Controllers.GameViewer
{
    [Authorize]
    public class GameController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly DatastoreDb _db;
        private string _kind;

        public GameController(ApplicationDbContext context)
        {
            _context = context;

            var projectId = "advanceddevelopment-262000";
            _db = DatastoreDb.Create(projectId);
            _kind = "game";
        }

        //GET
        public IActionResult Index()
        {
            List<GameViewModel> gameList = new List<GameViewModel>();
            Query query = new Query(_kind);

            foreach (var game in _db.RunQueryLazily(query))
            {
                GameViewModel gameViewModel = new GameViewModel();
                Enum.TryParse($"{game["gameType"].StringValue}", out GameType gameType);

                gameViewModel.Key = game.Key;
                gameViewModel.Name = $"{game["name"].StringValue}";
                gameViewModel.GameType = gameType;
                gameViewModel.GameUrl = $"{game["gameUrl"].StringValue}";
                gameViewModel.ImageUrl = $"{game["imageUrl"].StringValue}";

                gameList.Add(gameViewModel);
            }

            return View("~/Views/Home/GameViewer/Index.cshtml", gameList);
        }

        //GET
        public IActionResult Details(Key key)
        {
            List<Entity> gameEntities = new List<Entity>();
            GameViewModel viewModel = new GameViewModel();
            
            if (key == null)
            {
                return NotFound();
            }

            Query query = new Query(_kind)
            {
                Filter = Filter.And(Filter.Equal("key", key))
            };

            if (query.Equals(null))
            {
                return NotFound();
            }

            var game = _db.RunQueryLazily(query).FirstOrDefault();

            if (game != null)
            {
                Enum.TryParse($"{game["gameType"].StringValue}", out GameType gameType);

                viewModel.Key = game.Key;
                viewModel.Name = $"{game["name"].StringValue}";
                viewModel.GameType = gameType;
                viewModel.GameUrl = $"{game["gameUrl"].StringValue}";
                viewModel.ImageUrl = $"{game["imageUrl"].StringValue}";
            }

            //var game = await _context.Game
            //    .FirstOrDefaultAsync(m => m.Id == key);
            
            return View("~/Views/Home/GameViewer/Details.cshtml", viewModel);
        }

        // GET: Games/Create
        public IActionResult Create()
        {
            return View("~/Views/Home/GameViewer/Create.cshtml");
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,GameType,GameUrl,ImageUrl")] Game game)
        {
            List<Entity> gameEntities = new List<Entity>();
            Key incompleteKey = _db.CreateKeyFactory(_kind).CreateIncompleteKey();
            Key key = _db.AllocateId(incompleteKey);

            gameEntities.Add(
                new Entity
                {
                    Key = key,
                    ["name"] = game.Name,
                    ["gameType"] = game.GameType.ToString(),
                    ["gameUrl"] = game.GameUrl,
                    ["imageUrl"] = game.ImageUrl
                }
            );

            if (ModelState.IsValid)
            {
                //_context.Add(game);
                //await _context.SaveChangesAsync();
                using (var transaction = _db.BeginTransaction())
                {
                    transaction.Upsert(gameEntities);
                    transaction.Commit();
                }

                return RedirectToAction(nameof(Index));
            }
            return View("~/Views/Home/GameViewer/Create.cshtml", game);
        }

        // GET
        public IActionResult Edit(string key)
        {
            var dsKey = JsonConvert.DeserializeObject<Key>(key);

            GameViewModel viewModel = new GameViewModel();

            //Query query = new Query(_kind)
            //{
            //    Filter = Filter.And(Filter.Equal("key", dsKey))
            //};

            Entity gameEntity = _db.Lookup(dsKey);

            if (gameEntity.Equals(null))
            {
                return NotFound();
            }

            //var game = _db.RunQueryLazily(query).FirstOrDefault();

            //if (game == null)
            //{
            //    return NotFound();
            //}

            Enum.TryParse($"{gameEntity["gameType"].StringValue}", out GameType gameType);

            viewModel.Key = dsKey;
            viewModel.Name = $"{gameEntity["name"].StringValue}";
            viewModel.GameType = gameType;
            viewModel.GameUrl = $"{gameEntity["gameUrl"].StringValue}";
            viewModel.ImageUrl = $"{gameEntity["imageUrl"].StringValue}";

            return View("~/Views/Home/GameViewer/Edit.cshtml", viewModel);
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string key, [Bind("Key,Id,Name,GameType,GameUrl,ImageUrl")] GameViewModel game)
        {
            var dsKey = JsonConvert.DeserializeObject<Key>(key);

            Entity entity = _db.Lookup(dsKey);

            if (entity.Equals(null))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //_context.Update(game);
                    //await _context.SaveChangesAsync();

                    Entity gameEntity = new Entity
                    {
                        Key = dsKey,
                        ["name"] = game.Name,
                        ["gameType"] = game.GameType.ToString(),
                        ["gameUrl"] = game.GameUrl,
                        ["imageUrl"] = game.ImageUrl
                    };

                    using (var transaction = _db.BeginTransaction())
                    {
                        transaction.Update(gameEntity);
                        transaction.Commit();
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameExists(game.Key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View("~/Views/Home/GameViewer/Edit.cshtml", game);
        }

        //GET
        public IActionResult Delete(string key)
        {
            var dsKey = JsonConvert.DeserializeObject<Key>(key);
            GameViewModel viewModel = new GameViewModel();

            Entity gameEntity = _db.Lookup(dsKey);

            if (gameEntity.Equals(null))
            {
                return NotFound();
            }

            Enum.TryParse($"{gameEntity["gameType"].StringValue}", out GameType gameType);

            viewModel.Key = dsKey;
            viewModel.Name = $"{gameEntity["name"].StringValue}";
            viewModel.GameType = gameType;
            viewModel.GameUrl = $"{gameEntity["gameUrl"].StringValue}";
            viewModel.ImageUrl = $"{gameEntity["imageUrl"].StringValue}";

            return View("~/Views/Home/GameViewer/Delete.cshtml", viewModel);
        }

        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string key)
        {
            var dsKey = JsonConvert.DeserializeObject<Key>(key);

            _db.Delete(dsKey);

            return RedirectToAction(nameof(Index));
        }

        private bool GameExists(Key id)
        {
            Query query = new Query(_kind);

            return _db.RunQueryLazily(query).Any(e => e.Key.Equals(id));

            //return _context.Game.Any(e => e.Id == id);
        }
    }
}