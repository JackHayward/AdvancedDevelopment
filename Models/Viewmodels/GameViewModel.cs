using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AdvancedDevelopment.Models.GameViewer;
using Google.Cloud.Datastore.V1;

namespace AdvancedDevelopment.Models.ViewModels
{
    public class GameViewModel
    {
        public Key Key { get; set; }
        public int Id { get; set; }

        [Display(Name = "Name of Game")]
        public string Name { get; set; }

        [Display(Name = "Type of Game")]
        public GameType GameType { get; set; }

        [Display(Name = "Website")]
        public string GameUrl { get; set; }

        [Display(Name = "Game Logo")]
        public string ImageUrl { get; set; }
    }
}
