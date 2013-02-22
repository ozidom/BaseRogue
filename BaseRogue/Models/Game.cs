using BaseRogue.Models;
using BaseRogue.Models.GameObjects;
using BaseRogue.Models.TileObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseRogue.Models
{
    public class Game
    {
        public List<Tile> Level { get; set; }
        
        public Game()
        {
            Level = new List<Tile>();

            Level.Add(CreatureFactory.CreateCreature(0, GameEnums.CreatureType.human, 10, 10).GetTile());
            Level.Add(CreatureFactory.CreateCreature(0, GameEnums.CreatureType.elf, 140, 140).GetTile());
            Level.Add(CreatureFactory.CreateCreature(0, GameEnums.CreatureType.orc, 60, 60).GetTile());
            Level.Add(CreatureFactory.CreateCreature(0, GameEnums.CreatureType.dwarf, 80, 80).GetTile());

        }

    }
}
