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
    public class KartasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Kartas
        public ActionResult Index()
        {
            return View(db.Kartas.ToList());
        }

        // GET: Kartas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Karta karta = db.Kartas.Find(id);
            if (karta == null)
            {
                return HttpNotFound();
            }
            return View(karta);
        }

        // GET: Kartas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kartas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_karta,datum_na_izdavanje,id_klient,id_let,destinacija_od,destinacija_do,vreme_na_poaganje,cena")] Karta karta)
        {
            if (ModelState.IsValid)
            {
                db.Kartas.Add(karta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(karta);
        }

        // GET: Kartas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Karta karta = db.Kartas.Find(id);
            if (karta == null)
            {
                return HttpNotFound();
            }
            return View(karta);
        }

        // POST: Kartas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_karta,datum_na_izdavanje,id_klient,id_let,destinacija_od,destinacija_do,vreme_na_poaganje,cena")] Karta karta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(karta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(karta);
        }

        // GET: Kartas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Karta karta = db.Kartas.Find(id);
            if (karta == null)
            {
                return HttpNotFound();
            }
            return View(karta);
        }

        // POST: Kartas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Karta karta = db.Kartas.Find(id);
            db.Kartas.Remove(karta);
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
