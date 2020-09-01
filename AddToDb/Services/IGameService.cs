using AddToDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddToDb.Services
{
    public interface IGameService
    {
        List<Game> Games { get; }
        void AddGame(Game game);
        List<Game> GetGames();
    }
}
