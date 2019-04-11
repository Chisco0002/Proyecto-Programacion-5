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

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}