using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddToDb.Services;
using AddToDb.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AddToDb.Pages
{
    public class AddGameModel : PageModel
    {
        public IGameService _ns { get; set; }
        [BindProperty]
        public GameViewModel GVM { get; set; }
        public void OnGet()
        {

        }
        public AddGameModel(IGameService ns)
        {
            _ns = ns;
            GVM = new GameViewModel();
        }
        public IActionResult OnPost()
        {
            _ns.AddGame(new Models.Game { Title = GVM.Title, Autor = GVM.Autors, RealseDay = GVM.ReleaseDay, });
            return RedirectToPage("./ViewGames");

        }
    }
}