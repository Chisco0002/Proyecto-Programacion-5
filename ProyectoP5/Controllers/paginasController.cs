using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoP5.Controllers
{
    public class paginasController : Controller
    {
        // GET: paginas
        public ActionResult InformacionGeneral()
        {
            return View();
        }
		public ActionResult tasaDePolíticaMonetaria()
		{
			return View();
		}
		public ActionResult tasaBasicaPasiva()
		{
			return View();
		}
		public ActionResult dolar()
		{
			return View();
		}

		public ActionResult formulario()
		{
			return View();
		}

		public ActionResult formularioRecive(FormCollection form) { //desde esta accion se procedera a realizar el ingrso a la base de datos
			
				var nombre = form["txtName"];
				var cedula = form["txtCedula"];
				var edad = form["txtEdad"];
				var correo = form["txtCorreo"];
				var provincia = form["Provincia"];
				var canton = form["txtCanton"];
				var distrito = form["txtDistrito"];

				ViewBag.nombre = nombre;
				ViewBag.cedula = cedula;
				ViewBag.edad = edad;
				ViewBag.correo = correo;
				ViewBag.provincia = provincia;

			if (int.Parse(ViewBag.provincia) == 0)
			{
				ViewBag.provincia = "San Jose";
			}
			else if (int.Parse(ViewBag.provincia) == 1)
			{
				ViewBag.provincia = "Alajuelita";
			}
			else if (int.Parse(ViewBag.provincia) == 2)
			{
				ViewBag.provincia = "Guanacaste";
			}
			else if (int.Parse(ViewBag.provincia) == 3)
			{
				ViewBag.provincia = "Puntarenas";
			}
			else if (int.Parse(ViewBag.provincia) == 4)
			{
				ViewBag.provincia = "Limon";
			}
			else if (int.Parse(ViewBag.provincia) == 5)
			{
				ViewBag.provincia = "Heredia";
			}
			else
			{
				ViewBag.Provincia = "Cartago";
			}

			return View();
			

		}
		public ActionResult foro()
		{
			return View();
		}
		
		
	}
}