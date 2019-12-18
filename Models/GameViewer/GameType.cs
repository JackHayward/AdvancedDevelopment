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
        FPS,
        [Display(Name = "Massively Multiplayer Role Playing Game")]
        MMORPG,
        [Display(Name = "Role Playing Game")]
        RPG,
        [Display(Name = "Multiplayer Online Battle Arena")]
        MOBA,
        Strategy
    }
}
