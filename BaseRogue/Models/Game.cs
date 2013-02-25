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
            //Level.Add(CreatureFactory.CreateCreature(0, GameEnums.CreatureType.elf, 140, 140).GetTile());
            Level.Add(CreatureFactory.CreateCreature(0, GameEnums.CreatureType.orc, 60, 60).GetTile());
            Level.Add(CreatureFactory.CreateCreature(0, GameEnums.CreatureType.dwarf, 80, 80).GetTile());
            Level.Add(CreatureFactory.CreateCreature(0, GameEnums.CreatureType.orc, 160, 260).GetTile());
            Level.Add(CreatureFactory.CreateCreature(0, GameEnums.CreatureType.dwarf, 380, 280).GetTile());
            Level.Add(CreatureFactory.CreateCreature(0, GameEnums.CreatureType.orc, 130,160).GetTile());
            Level.Add(CreatureFactory.CreateCreature(0, GameEnums.CreatureType.dwarf, 330, 380).GetTile());


            Level.Add(new Tile { row = 20, col = 34, FileName = GameImages.BrownTile, Description = "Wall",canMove=false, ID = 1 });
            Level.Add(new Tile { row = 320, col = 264, FileName = GameImages.BrownTile, Description = "Wall", canMove = false, ID = 1 });
            Level.Add(new Tile { row = 220, col = 334, FileName = GameImages.BrownTile, Description = "Wall", canMove = false, ID = 1 });
            Level.Add(new Tile { row = 110, col = 334, FileName = GameImages.BrownTile, Description = "Wall", canMove = false, ID = 1 });
            Level.Add(new Tile { row = 55, col = 134, FileName = GameImages.BrownTile, Description = "Wall", canMove = false, ID = 1 });


            Level.Add(new Tile { row = 20, col = 34, FileName = GameImages.BrownTile, Description = "Wall", canMove = false, ID = 1 });

        }

    }
}
