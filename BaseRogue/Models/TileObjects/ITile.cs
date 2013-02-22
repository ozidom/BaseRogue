using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseRogue.Models.TileObjects
{
    public interface ITile
    {
        Tile GetTile();

        int X { get; set; }
        int Y { get; set; }
    }
}