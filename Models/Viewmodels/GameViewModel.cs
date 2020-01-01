﻿using System;
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

        [Display(Name = "Name")]
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public GameType GameType { get; set; }

        [Required]
        [Display(Name = "Website")]
        public string GameUrl { get; set; }

        [Required]
        [Display(Name = "Logo")]
        public string ImageUrl { get; set; }
    }
}
