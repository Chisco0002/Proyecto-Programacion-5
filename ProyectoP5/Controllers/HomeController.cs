using Newtonsoft.Json;
using ProyectoP5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoP5.Controllers
{
    public class HomeController : Controller
    {
        Clases.indicadorEconomico indi = new Clases.indicadorEconomico();
        public ActionResult Index()
        {

            if (Session["Cargado"] == null)
            {
                indi.tipoDeCambioVenta();
                indi.tipoDeCambioCompra();
                indi.tasaDePoliticaMonetaria();
                indi.tasaBasicaPasiva();

                System.Diagnostics.Debug.WriteLine("Carga: ");
                System.Diagnostics.Debug.WriteLine(Session["Cargado"]);

                Session["Cargado"] = 10;

            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Carga 2: ");
                System.Diagnostics.Debug.WriteLine(Session["Cargado"]);
            }


            return View();
        }




        ////// TipoCambioVenta
        public ActionResult GetTipoCambioVentaDash()
        {
            proyectoProgramacionVEntities3 pv = new proyectoProgramacionVEntities3();
            DateTime fecha = DateTime.Now.AddDays(-365);

            var query2 = pv.tipoDeCambioVenta.Where(x => x.desFecha > fecha).Select(x => new { x.desFecha, x.numValor, x.codIndicador }).ToList();

            string jsonTemp = JsonConvert.SerializeObject(query2);

            return Json(jsonTemp, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetUltimoTipoCambioVenta()
        {
            proyectoProgramacionVEntities3 pv = new proyectoProgramacionVEntities3();

            var query2 = pv.tipoDeCambioVenta.OrderByDescending(p => p.desFecha).FirstOrDefault();


            string jsonTemp = JsonConvert.SerializeObject(query2);


            return Json(jsonTemp, JsonRequestBehavior.AllowGet);
        }


        public ActionResult GetTipoCambioVenta()
        {
            proyectoProgramacionVEntities3 pv = new proyectoProgramacionVEntities3();

            var query2 = pv.tipoDeCambioVenta.Select(x => new { x.desFecha, x.numValor, x.codIndicador }).ToList();


            string jsonTemp = JsonConvert.SerializeObject(query2);

            return Json(jsonTemp, JsonRequestBehavior.AllowGet);
        }

        ////// TipoCambioCompra
        public ActionResult GetTipoCambioCompraDash()
        {
            DateTime fecha = DateTime.Now.AddDays(-365);
            proyectoProgramacionVEntities3 pv = new proyectoProgramacionVEntities3();

            var query2 = pv.tipoDeCambioCompra.Where(x => x.desFecha > fecha).Select(x => new { x.desFecha, x.numValor, x.codIndicador }).ToList();

            string jsonTemp = JsonConvert.SerializeObject(query2);

            return Json(jsonTemp, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetUltimoTipoCambioCompra()
        {
            proyectoProgramacionVEntities3 pv = new proyectoProgramacionVEntities3();

            var query2 = pv.tipoDeCambioCompra.OrderByDescending(p => p.desFecha).FirstOrDefault();

            string jsonTemp = JsonConvert.SerializeObject(query2);

            return Json(jsonTemp, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetTipoCambioCompra()
        {
            proyectoProgramacionVEntities3 pv = new proyectoProgramacionVEntities3();

            var query2 = pv.tipoDeCambioCompra.Select(x => new { x.desFecha, x.numValor, x.codIndicador }).ToList();

            string jsonTemp = JsonConvert.SerializeObject(query2);

            return Json(jsonTemp, JsonRequestBehavior.AllowGet);
        }

        ////// TasaBasicaPasiva
        public ActionResult GetTasaBasicaPasivaDash()
        {
            proyectoProgramacionVEntities3 pv = new proyectoProgramacionVEntities3();
            DateTime fecha = DateTime.Now.AddDays(-365);

            var query2 = pv.tasaBasicaPasiva.Where(x => x.desFecha > fecha).Select(x => new { x.desFecha, x.numValor, x.codIndicador }).ToList();

            string jsonTemp = JsonConvert.SerializeObject(query2);

            return Json(jsonTemp, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetUltimaTasaBasicaPasiva()
        {
            proyectoProgramacionVEntities3 pv = new proyectoProgramacionVEntities3();

            var query2 = pv.tasaBasicaPasiva.OrderByDescending(p => p.desFecha).FirstOrDefault();

            string jsonTemp = JsonConvert.SerializeObject(query2);

            return Json(jsonTemp, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetTasaBasicaPasiva()
        {
            proyectoProgramacionVEntities3 pv = new proyectoProgramacionVEntities3();

            var query2 = pv.tasaBasicaPasiva.Select(x => new { x.desFecha, x.numValor, x.codIndicador }).ToList();

            string jsonTemp = JsonConvert.SerializeObject(query2);

            return Json(jsonTemp, JsonRequestBehavior.AllowGet);
        }

        ////// TasaPoliticaMonetaria
        public ActionResult GetTasaDePoliticaMonetariaDash()
        {
            proyectoProgramacionVEntities3 pv = new proyectoProgramacionVEntities3();
            DateTime fecha = DateTime.Now.AddDays(-365);

            var query2 = pv.tasaDePolíticaMonetaria.Where(x => x.desFecha > fecha).Select(x => new { x.desFecha, x.numValor, x.codIndicador }).ToList();

            string jsonTemp = JsonConvert.SerializeObject(query2);

            return Json(jsonTemp, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetUltimaTasaDePoliticaMonetaria()
        {
            proyectoProgramacionVEntities3 pv = new proyectoProgramacionVEntities3();

            var query2 = pv.tasaDePolíticaMonetaria.OrderByDescending(p => p.desFecha).FirstOrDefault();

            string jsonTemp = JsonConvert.SerializeObject(query2);

            return Json(jsonTemp, JsonRequestBehavior.AllowGet);
        }


        public ActionResult GetTasaDePoliticaMonetaria()
        {
            proyectoProgramacionVEntities3 pv = new proyectoProgramacionVEntities3();

            var query2 = pv.tasaDePolíticaMonetaria.Select(x => new { x.desFecha, x.numValor, x.codIndicador }).ToList();

            string jsonTemp = JsonConvert.SerializeObject(query2);

            return Json(jsonTemp, JsonRequestBehavior.AllowGet);
        }

    }
}