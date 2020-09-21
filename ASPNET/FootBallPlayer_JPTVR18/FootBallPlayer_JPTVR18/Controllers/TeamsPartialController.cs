using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FootBallPlayer_JPTVR18.Models;

namespace FootBallPlayer_JPTVR18.Controllers
{
    public class TeamsPartialController : Controller
    {
        private FootballClubContext db = new FootballClubContext();

        // GET: TeamsPartial
        public ActionResult Index()
        {
            return View(db.Teams.ToList());
        }

        // GET: TeamsPartial/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Team team = db.Teams.Find(id);
            team = db.Teams.Include(z => z.Players).FirstOrDefault(z => z.Id== id);
            if (team == null)
            {
                return HttpNotFound();
            }
            return View(team);
        }
        [ChildActionOnly]

        public ActionResult PlayersInTeam(int id)
        {
            var teamPlayers = db.Players.Where(p => p.TeamId == id);
            return PartialView(teamPlayers);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }


}
