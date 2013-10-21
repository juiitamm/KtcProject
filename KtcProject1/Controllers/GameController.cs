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
            Game game = new Game();
            return View(game);
        }

        [HttpPost]
        public ActionResult Index(Game game)
        {
            if(ModelState.IsValid)
                return RedirectToAction("Play", game);
            return View();
        }

        public ActionResult Play(Game game)
        {
            return View(game);
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
