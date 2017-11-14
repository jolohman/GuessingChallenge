using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GuessingChallenge.Models
{
    public class GameModel
    {
        [Required]
        [Display(Name = "Player Name")]
        [MaxLength(25, ErrorMessage ="Name must be less than 25 characters")]
        public string PlayerName { get; set; }

        [Range(1,10, ErrorMessage = "A valid response is a number 1-10") ]
        public int Guess { get; set; }
    }
}