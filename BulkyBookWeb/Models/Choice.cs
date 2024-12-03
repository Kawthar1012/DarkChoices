using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Choice
    {
        public Choice? ChoiceOne { get; set; } 
        public Choice? ChoiceTwo { get; set; }
        public string? ChoiceOneText { get; set; }
        public string? ChoiceTwoText { get; set; }
        public string Video { get; set; } = "";
        public string? Loop { get; set; }
        public bool End { get; set; } = false;
        

    }
}
