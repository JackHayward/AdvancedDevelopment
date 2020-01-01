﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Google.Cloud.Datastore.V1;

namespace AdvancedDevelopment.Models.GameViewer
{
    public class Game
    {
        public int Id { get; set; }
        public Key Key { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        public GameType GameType { get; set; }

        [Required]
        [DataType(DataType.Url)]
        [Display(Name = "Website")]
        public string GameUrl { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Logo")]
        public string ImageUrl { get; set; }
    }
}
