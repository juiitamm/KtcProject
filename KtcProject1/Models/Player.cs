using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KtcProject1.Models
{
    public class Player
    {
        private const string NameRequiredError = "A name is required!";

        [DisplayName("Player Name")]
        [Required(ErrorMessage = NameRequiredError)]
        public string Name { get; set; }

        [ScaffoldColumn(false)]
        public int Games { get; set; }
        
        [ScaffoldColumn(false)]
        public int Wins { get; set; }
        
        [ScaffoldColumn(false)]
        public int Fumbles { get; set; }
        
        [ScaffoldColumn(false)]
        public int Chimneys { get; set; }


        public static string GetNameErrorMessage()
        {
            return NameRequiredError;
        }
    }
}