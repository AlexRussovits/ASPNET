using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyPainterJPTVR18.Models;

namespace MyPainterJPTVR18.Controllers
{
    public class PainterPicturesController : Controller
    {
        private PainterContext db = new PainterContext();

        // GET: PainterPictures
        public ActionResult Index()
        {
            return View(db.Painters.ToList());
        }

        public ActionResult PainterPictures()
        {
            var pName = db.Painters.ToList();
            return PartialView(pName);
        }

        public ActionResult Browse(int id)
        {
            var pPictures = db.Painters.Include(p => p.pictures).Single(i => i.Id == id);
            return View(pPictures);
        }
    }
}
