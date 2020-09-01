using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddToDb.Models;
using AddToDb.Services;
using AddToDb.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AddToDb.Pages
{
    public class ViewGamesModel : PageModel
    {
        public IGameService _gameService;
        public GameViewModel Game { get; set; }
        [BindProperty]
        public List<Game> Games { get; set; }
        public ViewGamesModel(IGameService gameService)
        {
            _gameService = gameService;
            Games = new List<Game>();
        }
        public void OnGet()
        {
            Games = _gameService.GetGames();

        }
    }
}