using BaseRogue.Models;
using BaseRogue.Models.TileObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaseRogue.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Sync(List<Tile> level)
        {
            Game game = GetGame(level);
            SetGame(game);
            return Json(game.Level);
        }

        private Game GetGame(List<Tile> map)
        {
            Game game;
            if (Session["galaxy"] == null)
            {
                game = new Game();
                Session["game"] = game;
            }

            game = (Game)Session["game"];
            if (map != null)
            {
                game.Level = map;
            }
            return game;
        }

        private void SetGame(Game game)
        {
            Session["game"] = game;
        }
    
    }
}
