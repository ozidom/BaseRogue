using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseRogue.Models
{
    public class Tile : BaseGameObject
    {
        public string FileName {get;set;}
        public int row { get; set; }
        public int col { get; set; }
        public string directionImage { get; set; }
    }
}