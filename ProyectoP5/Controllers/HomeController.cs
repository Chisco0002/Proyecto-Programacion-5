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
			indi.tipoDeCambioVenta();
			indi.tipoDeCambioCompra();
			indi.tasaDePoliticaMonetaria();
			indi.tasaBasicaPasiva();
			return View();
		}

        public ActionResult GetData()
        {
            proyectoProgramacionVEntities3 pv = new proyectoProgramacionVEntities3();
            var query = pv.tipoDeCambioCompra.GroupBy(p => p.desFecha).
                Select(g => new { date = g.Key}).ToList();
            //var query = pv.tipoDeCambioCompra.Select(x => new { Date = x.desFecha, Value = x.numValor }).ToList();
            return Json(query, JsonRequestBehavior.AllowGet);
		}

	}
}