using BaseRogue.Models.GameObjects;
using BaseRogue.Models.TileObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseRogue.Models
{
    public class CreatureFactory
    {
        public static Creature CreateCreature(int id, BaseRogue.Models.GameEnums.CreatureType type,int x,int y)
        {

            string description, imageFileName;
            CreateCreatureProperties(type, out description, out imageFileName);

            Creature c = new Creature(id, description, imageFileName,x,y);
            return c;
            

        }

        private static void CreateCreatureProperties(BaseRogue.Models.GameEnums.CreatureType type, out string description, out string imageFileName)
        {
            switch (type)
            {
                case GameEnums.CreatureType.human:
                    description = "Human";
                    imageFileName = GameImages.PinkMan;
                    break;
                case GameEnums.CreatureType.dwarf:
                    description = "Dwarf";
                    imageFileName = GameImages.GreenMan;
                    break;
                case GameEnums.CreatureType.elf:
                    description = "Elf";
                    imageFileName = GameImages.WhiteMan;
                    break;
                case GameEnums.CreatureType.orc:
                    description = "Orc";
                    imageFileName = GameImages.RedMan;
                    break;
                default:
                    description = "Nothing";
                    imageFileName = GameImages.BlueTile;
                    break;
            }
        }


    }
}