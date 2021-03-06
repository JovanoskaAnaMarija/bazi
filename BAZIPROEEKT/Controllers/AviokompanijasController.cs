using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BAZIPROEEKT.Models;

namespace BAZIPROEEKT.Controllers
{
    public class AviokompanijasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Aviokompanijas
        public ActionResult Index()
        {
            return View(db.Aviokompanijas.ToList());
        }

        // GET: Aviokompanijas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aviokompanija aviokompanija = db.Aviokompanijas.Find(id);
            if (aviokompanija == null)
            {
                return HttpNotFound();
            }
            return View(aviokompanija);
        }

        // GET: Aviokompanijas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aviokompanijas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_avio,ime,drzava")] Aviokompanija aviokompanija)
        {
            if (ModelState.IsValid)
            {
                db.Aviokompanijas.Add(aviokompanija);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aviokompanija);
        }

        // GET: Aviokompanijas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aviokompanija aviokompanija = db.Aviokompanijas.Find(id);
            if (aviokompanija == null)
            {
                return HttpNotFound();
            }
            return View(aviokompanija);
        }

        // POST: Aviokompanijas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_avio,ime,drzava")] Aviokompanija aviokompanija)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aviokompanija).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aviokompanija);
        }

        // GET: Aviokompanijas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aviokompanija aviokompanija = db.Aviokompanijas.Find(id);
            if (aviokompanija == null)
            {
                return HttpNotFound();
            }
            return View(aviokompanija);
        }

        // POST: Aviokompanijas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Aviokompanija aviokompanija = db.Aviokompanijas.Find(id);
            db.Aviokompanijas.Remove(aviokompanija);
            db.SaveChanges();
            return RedirectToAction("Index");
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
