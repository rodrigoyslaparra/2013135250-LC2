using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2013204637;
using _2013204637_PER;

namespace _2013204637_MVC.Controllers
{
    public class ATMsController : Controller
    {
        private ATMDbContext db = new ATMDbContext();

        // GET: ATMs
        public ActionResult Index()
        {
            return View(db.ATMs.ToList());
        }

        // GET: ATMs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ATM aTM = db.ATMs.Find(id);
            if (aTM == null)
            {
                return HttpNotFound();
            }
            return View(aTM);
        }

        // GET: ATMs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ATMs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ATMId,DescATM")] ATM aTM)
        {
            if (ModelState.IsValid)
            {
                db.ATMs.Add(aTM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aTM);
        }

        // GET: ATMs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ATM aTM = db.ATMs.Find(id);
            if (aTM == null)
            {
                return HttpNotFound();
            }
            return View(aTM);
        }

        // POST: ATMs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ATMId,DescATM")] ATM aTM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aTM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aTM);
        }

        // GET: ATMs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ATM aTM = db.ATMs.Find(id);
            if (aTM == null)
            {
                return HttpNotFound();
            }
            return View(aTM);
        }

        // POST: ATMs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ATM aTM = db.ATMs.Find(id);
            db.ATMs.Remove(aTM);
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
