using BaseRogue.Models.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseRogue.Models.TileObjects
{
    public class Creature : BaseGameObject, ITile
    {
        string fileName;
        public Creature(int id,string description,string fileName,int x, int y)
        {
            ID = id;
            Description = description;
            X = x;
            Y = y;
            this.fileName = fileName;
        }

        public Tile GetTile()
        {
            Tile t = new Tile { row = Y, col = X, ID = ID, Description = this.Description,FileName = fileName };
            return t;
        }

        public int X { get;set;}
        public int Y { get;set;}
       
    }
}