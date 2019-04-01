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
    public class foroConsulatasController : Controller
    {
        private proyectoProgramacionVEntities3 db = new proyectoProgramacionVEntities3();
		
        // GET: foroConsulatas
        public ActionResult Index()
        {
					
			return View(db.foroConsulata.ToList());
			
		
		}

        // GET: foroConsulatas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            foroConsulata foroConsulata = db.foroConsulata.Find(id);
            if (foroConsulata == null)
            {
                return HttpNotFound();
            }
            return View(foroConsulata);
        }

        // GET: foroConsulatas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: foroConsulatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "consultaID,nombreRemitente,tituloConsulta,detalleConsulta")] foroConsulata foroConsulata)
        {
            if (ModelState.IsValid)
            {
                db.foroConsulata.Add(foroConsulata);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(foroConsulata);
        }

        // GET: foroConsulatas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            foroConsulata foroConsulata = db.foroConsulata.Find(id);
            if (foroConsulata == null)
            {
                return HttpNotFound();
            }
            return View(foroConsulata);
        }

        // POST: foroConsulatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "consultaID,nombreRemitente,tituloConsulta,detalleConsulta")] foroConsulata foroConsulata)
        {
            if (ModelState.IsValid)
            {
                db.Entry(foroConsulata).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(foroConsulata);
        }

        // GET: foroConsulatas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            foroConsulata foroConsulata = db.foroConsulata.Find(id);
            if (foroConsulata == null)
            {
                return HttpNotFound();
            }
            return View(foroConsulata);
        }

        // POST: foroConsulatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            foroConsulata foroConsulata = db.foroConsulata.Find(id);
            db.foroConsulata.Remove(foroConsulata);
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
