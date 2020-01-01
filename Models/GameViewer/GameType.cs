using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedDevelopment.Models.GameViewer
{
    public enum GameType
    {
        [Display(Name = "First Person Shooter")]
        Fps,
        [Display(Name = "Massively Multiplayer Role Playing Game")]
        Mmorpg,
        [Display(Name = "Role Playing Game")]
        Rpg,
        [Display(Name = "Multiplayer Online Battle Arena")]
        Moba,
        Strategy
    }
}
