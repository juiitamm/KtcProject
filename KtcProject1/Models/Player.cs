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
        [DisplayName("Player Name")]
        public string Name { get; set; }
        
        [ScaffoldColumn(false)]
        public int Games { get; set; }
        
        [ScaffoldColumn(false)]
        public int Wins { get; set; }
        
        [ScaffoldColumn(false)]
        public int Fumbles { get; set; }
        
        [ScaffoldColumn(false)]
        public int Chimneys { get; set; }
    }
}