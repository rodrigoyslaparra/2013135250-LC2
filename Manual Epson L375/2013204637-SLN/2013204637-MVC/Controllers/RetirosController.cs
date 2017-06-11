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
    public class RetirosController : Controller
    {
        private ATMDbContext db = new ATMDbContext();

        // GET: Retiros
        public ActionResult Index()
        {
            var retiros = db.Retiros.Include(r => r.ATM).Include(r => r.Cuenta);
            return View(retiros.ToList());
        }

        // GET: Retiros/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Retiro retiro = db.Retiros.Find(id);
            if (retiro == null)
            {
                return HttpNotFound();
            }
            return View(retiro);
        }

        // GET: Retiros/Create
        public ActionResult Create()
        {
            ViewBag.ATMId = new SelectList(db.ATMs, "ATMId", "DescATM");
            ViewBag.CuentaId = new SelectList(db.Cuentas, "CuentaId", "DescCuenta");
            return View();
        }

        // POST: Retiros/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RetiroId,Monto,DescRetiro,FechaRetiro,ATMId,CuentaId")] Retiro retiro)
        {
            if (ModelState.IsValid)
            {
                db.Retiros.Add(retiro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ATMId = new SelectList(db.ATMs, "ATMId", "DescATM", retiro.ATMId);
            ViewBag.CuentaId = new SelectList(db.Cuentas, "CuentaId", "DescCuenta", retiro.CuentaId);
            return View(retiro);
        }

        // GET: Retiros/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Retiro retiro = db.Retiros.Find(id);
            if (retiro == null)
            {
                return HttpNotFound();
            }
            ViewBag.ATMId = new SelectList(db.ATMs, "ATMId", "DescATM", retiro.ATMId);
            ViewBag.CuentaId = new SelectList(db.Cuentas, "CuentaId", "DescCuenta", retiro.CuentaId);
            return View(retiro);
        }

        // POST: Retiros/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RetiroId,Monto,DescRetiro,FechaRetiro,ATMId,CuentaId")] Retiro retiro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(retiro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ATMId = new SelectList(db.ATMs, "ATMId", "DescATM", retiro.ATMId);
            ViewBag.CuentaId = new SelectList(db.Cuentas, "CuentaId", "DescCuenta", retiro.CuentaId);
            return View(retiro);
        }

        // GET: Retiros/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Retiro retiro = db.Retiros.Find(id);
            if (retiro == null)
            {
                return HttpNotFound();
            }
            return View(retiro);
        }

        // POST: Retiros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Retiro retiro = db.Retiros.Find(id);
            db.Retiros.Remove(retiro);
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
