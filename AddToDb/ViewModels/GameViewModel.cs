using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddToDb.ViewModels
{
    public class GameViewModel
    {
        public int Id { get; set;  }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Autors { get; set; }
        [Required]
        public string ReleaseDay { get; set; }
    }
}
