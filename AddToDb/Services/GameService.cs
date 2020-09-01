using AddToDb.Models;
using AddToDb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddToDb
{
    public class GameService : IGameService
    {
        public ApplicationDbContext _db { get; set; }
        public GameService(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<Game> Games { get => _db.Games.ToList(); }
        public List<Game> GetGames()
        {
            return _db.Games.ToList();
        }
        public void AddGame(Game game)
        {
            _db.Games.Add(game);
            _db.SaveChanges();
        }
    }
}
