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
    public class LetsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Lets
        public ActionResult Index()
        {
            return View(db.Lets.ToList());
        }

        // GET: Lets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Let let = db.Lets.Find(id);
            if (let == null)
            {
                return HttpNotFound();
            }
            return View(let);
        }

        // GET: Lets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_let,destinacija_od,destinacija_do,datum,cena,id_avio")] Let let)
        {
            if (ModelState.IsValid)
            {
                db.Lets.Add(let);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(let);
        }

       

        // GET: Lets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Let let = db.Lets.Find(id);
            if (let == null)
            {
                return HttpNotFound();
            }
            return View(let);
        }

        // POST: Lets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_let,destinacija_od,destinacija_do,datum,cena,id_avio")] Let let)
        {
            if (ModelState.IsValid)
            {
                db.Entry(let).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(let);
        }

        // GET: Lets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Let let = db.Lets.Find(id);
            if (let == null)
            {
                return HttpNotFound();
            }
            return View(let);
        }

        // POST: Lets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Let let = db.Lets.Find(id);
            db.Lets.Remove(let);
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
