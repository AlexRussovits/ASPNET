using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FilmsJPTVR18_Russovits.Models;

namespace FilmsJPTVR18_Russovits.Controllers
{
    public class FilmsController : Controller
    {
        private FilmsJPTVR18Entities db = new FilmsJPTVR18Entities();

        // GET: Films
        [Authorize(Roles = "admin")]
        public ActionResult Index()

        {
            return View(db.Films.OrderByDescending(i => i.Id).ToList());
        }

        // GET: Films/Details/5
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

        [Authorize(Roles = "admin")]
        // GET: Films/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Films/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Year,Description,Cover,ImageMimeType,Country")] Film film, HttpPostedFileBase Image)
        {
            if (ModelState.IsValid)
            {
                if (Image != null)
                {
                    film.ImageMimeType = Image.ContentType;
                    film.Cover = new byte[Image.ContentLength];
                    Image.InputStream.Read(film.Cover, 0, Image.ContentLength);
                }

                db.Films.Add(film);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(film);
        }

        // GET: Films/Edit/5
        [Authorize(Roles = "admin")]
        public ActionResult Edit(int? id)
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

        // POST: Films/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Year,Description,Cover,ImageMimeType,Country")] Film film, HttpPostedFileBase Image)
        {
            if (ModelState.IsValid)
            {
                if (Image != null)
                {
                    film.ImageMimeType = Image.ContentType;
                    film.Cover = new byte[Image.ContentLength];
                    Image.InputStream.Read(film.Cover, 0, Image.ContentLength);
                }

                db.Entry(film).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(film);
        }

        // GET: Films/Delete/5
        [Authorize(Roles = "admin")]
        public ActionResult Delete(int? id)
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

        // POST: Films/Delete/5
        [Authorize(Roles = "admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var fa = this.db.FilmActors.Include(f => f.Film).FirstOrDefault(f => f.FilmId == id);
            if (fa != null)
            {
                return RedirectToAction("Delete", "FilmActors", new { id = fa.Id });
            }
            else { 
            Film film = db.Films.Find(id);
            db.Films.Remove(film);
            db.SaveChanges();
            return RedirectToAction("Index");
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
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
    }
}
