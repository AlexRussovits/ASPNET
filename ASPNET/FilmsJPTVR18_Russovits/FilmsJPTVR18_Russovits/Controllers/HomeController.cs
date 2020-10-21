using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;
using FilmsJPTVR18_Russovits.Models;

namespace FilmsJPTVR18_Russovits.Controllers
{
    public class HomeController : Controller
    {
        private FilmsJPTVR18Entities db = new FilmsJPTVR18Entities();

        // GET: Home
        public ActionResult Index()
        {
            return View(db.Films.OrderByDescending(v => v.Id).Take(3).ToList());
        }

        public ActionResult Films()
        {
            return View(db.Films.OrderByDescending(f => f.Id).ToList());
        }

        public FileContentResult GetImage(int id)
        {
            Film film = db.Films.FirstOrDefault(f => f.Id == id);
            if (film.Cover != null)
            {
                return File(film.Cover, film.ImageMimeType);
            }
            return null;
        }

        // GET: Home/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        [ChildActionOnly]
        public ActionResult GetFilmActors(int id)
        {
            return PartialView(db.FilmActors.Include(f => f.Actor).Where(f => f.FilmId == id));
        }

        //Show films with search 
        public ActionResult FilmsWithSearch(int? page)
        {
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            var films = db.Films.OrderByDescending(f => f.Id).ToList();
            return View(films.ToPagedList(pageNumber, pageSize));
        }

        [HttpPost]
        //Show films by ajax search 
        public ActionResult FilmsWithSearchPost(string FilmName, int? page)
        {

            var films = this.db.Films.Where(f => f.Title.Contains(FilmName)).ToList();
            if (films.Count <= 0)
            {
                return HttpNotFound();
            }
            return PartialView(films);
        }
    }
}
