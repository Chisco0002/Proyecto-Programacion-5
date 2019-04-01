using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProyectoP5.Models;

namespace ProyectoP5.Controllers
{
    public class foroRespuestasController : Controller
    {
        private proyectoProgramacionVEntities3 db = new proyectoProgramacionVEntities3();

        // GET: foroRespuestas
        public ActionResult Index()
        {
            var foroRespuestas = db.foroRespuestas.Include(f => f.foroConsulata);
            return View(foroRespuestas.ToList());
        }

        // GET: foroRespuestas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            foroRespuestas foroRespuestas = db.foroRespuestas.Find(id);
            if (foroRespuestas == null)
            {
                return HttpNotFound();
            }
            return View(foroRespuestas);
        }

        // GET: foroRespuestas/Create
        public ActionResult Create()
        {
            ViewBag.consultaID = new SelectList(db.foroConsulata, "consultaID", "nombreRemitente");
            return View();
        }

        // POST: foroRespuestas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "nombreReceptor,detalleRespuesta,consultaID")] foroRespuestas foroRespuestas)
        {
            if (ModelState.IsValid)
            {
                db.foroRespuestas.Add(foroRespuestas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.consultaID = new SelectList(db.foroConsulata, "consultaID", "nombreRemitente", foroRespuestas.consultaID);
            return View(foroRespuestas);
        }

        // GET: foroRespuestas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            foroRespuestas foroRespuestas = db.foroRespuestas.Find(id);
            if (foroRespuestas == null)
            {
                return HttpNotFound();
            }
            ViewBag.consultaID = new SelectList(db.foroConsulata, "consultaID", "nombreRemitente", foroRespuestas.consultaID);
            return View(foroRespuestas);
        }

        // POST: foroRespuestas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "respuestaID,nombreReceptor,detalleRespuesta,consultaID")] foroRespuestas foroRespuestas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(foroRespuestas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.consultaID = new SelectList(db.foroConsulata, "consultaID", "nombreRemitente", foroRespuestas.consultaID);
            return View(foroRespuestas);
        }

        // GET: foroRespuestas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            foroRespuestas foroRespuestas = db.foroRespuestas.Find(id);
            if (foroRespuestas == null)
            {
                return HttpNotFound();
            }
            return View(foroRespuestas);
        }

        // POST: foroRespuestas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            foroRespuestas foroRespuestas = db.foroRespuestas.Find(id);
            db.foroRespuestas.Remove(foroRespuestas);
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
