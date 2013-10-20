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
        public ActionResult Play(Game game)
        {
            return View(game);
        }

    }
}
