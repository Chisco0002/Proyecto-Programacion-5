using ProyectoP5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using System.Net;




namespace ProyectoP5.Controllers
{
    public class foroController : Controller
    {
        private proyectoProgramacionVEntities3 db = new proyectoProgramacionVEntities3();

        // GET: Foro
        public ActionResult Index()
        {
            return View(db.foroConsulata.ToList());
        }

        List<foroRespuestas> listaRespuesta = new List<foroRespuestas>();
        public List<foroRespuestas> consultaBaseDeDatos(int id)
        {

            try
            {
                var lista = db.foroRespuestas.ToList();

                if (lista.Count() > 0)
                {
                    foreach (var item in lista)
                    {
                        if (item.consultaID == id)
                        {
                            foroRespuestas resp = new foroRespuestas()
                            {
                                consultaID = item.consultaID,
                                detalleRespuesta = item.detalleRespuesta,
                                foroConsulata = item.foroConsulata,
                                nombreReceptor = item.nombreReceptor,
                                respuestaID = item.respuestaID
                            };
                            listaRespuesta.Add(resp);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                return null;
            }
            return listaRespuesta;
        }
        public ActionResult Respuestas(int id)
        {
            consultaBaseDeDatos(id);
            return View(listaRespuesta);
        }



        public ActionResult agregarRespuesta()
        {
            ViewBag.consultaID = new SelectList(db.foroConsulata, "consultaID", "nombreRemitente");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult agregarRespuesta([Bind(Include = "respuestaID,nombreReceptor,detalleRespuesta,consultaID")] foroRespuestas foroRespuestas)
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


        // GET: foroConsulatas/Create
        public ActionResult crearConsulta()
        {
            return View();
        }

        // POST: foro/crearConsulta
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult crearConsulta([Bind(Include = "consultaID,nombreRemitente,tituloConsulta,detalleConsulta")] foroConsulata foroConsulata)
        {
            if (ModelState.IsValid)
            {
                db.foroConsulata.Add(foroConsulata);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(foroConsulata);
        }
    }
}
