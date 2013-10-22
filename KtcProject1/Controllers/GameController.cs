using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KtcProject1.Models;

namespace KtcProject1.Controllers
{
    public class GameController : Controller
    {
        //
        // GET: /Game/
        public ActionResult Index()
        {
            return View(new Game());
        }

        //POST: /Game/
        [HttpPost]
        public ActionResult Index(Game game)
        {
            if (ModelState.IsValid)
            {
                //Using TempData to pass the game to Play-method:
                TempData["gameData"] = game;
                return RedirectToAction("Play");
            }
            return View(game);
        }

        //GET: /Game/Play
        public ActionResult Play()
        {
            Game game = TempData["gameData"] as Game;
            if (game == null)
                return RedirectToAction("Index");
            return View("Play", game);

        }

        //AJAX GET: /Game/AddPlayer/2
        public ActionResult AddPlayer(int id)
        {
            ViewBag.PlayerIndex = id;
            ViewBag.PlayerNameError = Player.GetNameErrorMessage();
            return View("Partial/NewPlayer");
        }

    }
}
