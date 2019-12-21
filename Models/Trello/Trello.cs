using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedDevelopment.Models.Trello
{
    public class Trello
    {
        [Required(ErrorMessage = "Please make sure the card name is not empty")]
        [StringLength(20, ErrorMessage = "Card name length must be between {2} and {1}.", MinimumLength = 5)]
        public string CardName { get; set; }
    }
}
