using AjaxImageDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxImageDemo.Controllers
{
    public class PlayersController : Controller
    {
        

        // GET: Players
        public ActionResult Index()
        {
            
            return View();
        }

        [HttpGet]
        public JsonResult GetPlayers(int? page, int? limit, string sortBy, string direction, string searchString = null)
        {
            List<Player> playerList = new List<Player>();
            playerList.Add(new Player());
            playerList.Add(new Player());
            playerList.Add(new Player());
            playerList.Add(new Player());
            playerList.Add(new Player());
            playerList.Add(new Player());
            playerList.Add(new Player());
            playerList.Add(new Player());
            playerList.Add(new Player());
            playerList.Add(new Player());
            playerList.Add(new Player());
            playerList.Add(new Player());
            playerList.Add(new Player());
            playerList.Add(new Player());
            playerList.Add(new Player());
            int total = 10;
            var records = playerList;
            return Json(new { records, total }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Save(Player player)
        {
            //new GridModel().Save(player);
            return Json(true);
        }

        [HttpPost]
        public JsonResult Remove(int id)
        {
            //new GridModel().Remove(id);
            return Json(true);
        }
    }
}