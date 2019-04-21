using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        protected void usuariosConeccion(string nombreUsuario, string cedulaUsuario,
                                        int edadUsuario, string correoUsuario,
                                        string profesiónUsuario, string provinciaUsuario,
                                        string cantonUsuario, string distritoUsuario)
        {


            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=proyectoProgramacionV;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insercion_Usuario", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nombreUsuario", nombreUsuario);
            cmd.Parameters.AddWithValue("cedulaUsuario", cedulaUsuario);
            cmd.Parameters.AddWithValue("edadUsuario", edadUsuario);
            cmd.Parameters.AddWithValue("correoUsuario", correoUsuario);
            cmd.Parameters.AddWithValue("profesiónUsuario", profesiónUsuario);
            cmd.Parameters.AddWithValue("provinciaUsuario", provinciaUsuario);
            cmd.Parameters.AddWithValue("cantonUsuario", cantonUsuario);
            cmd.Parameters.AddWithValue("distritoUsuario", distritoUsuario);


            con.Open();
            int k = cmd.ExecuteNonQuery();
            if (k != 0)
            {
            }
            con.Close();
        }

        public ActionResult formularioRecive(FormCollection form)
        { //desde esta accion se procedera a realizar el ingrso a la base de datos

            var nombre = form["txtNombre"];
            var cedula = form["txtCedula"];
            var edad = form["txtEdad"];
            var correo = form["txtCorreo"];
            var profecion = form["txtProfecion"];
            var provincia = form["Provincia"];
            var canton = form["txtCanton"];
            var distrito = form["txtDistrito"];

            ViewBag.Provincia = provincia;
            ViewBag.Nombre = nombre;
            ViewBag.cedula = cedula;
            ViewBag.edad = edad;
            ViewBag.Correo = correo;
            ViewBag.profecion = profecion;
            ViewBag.canton = canton;
            ViewBag.distrito = distrito;

            if (int.Parse(ViewBag.Provincia) == 0)
            {
                ViewBag.Provincia = "San Jose";
            }
            else if (int.Parse(ViewBag.Provincia) == 1)
            {
                ViewBag.Provincia = "Alajuela";
            }
            else if (int.Parse(ViewBag.Provincia) == 2)
            {
                ViewBag.Provincia = "Guanacaste";
            }
            else if (int.Parse(ViewBag.Provincia) == 3)
            {
                ViewBag.Provincia = "Puntarenas";
            }
            else if (int.Parse(ViewBag.Provincia) == 4)
            {
                ViewBag.Provincia = "Limon";
            }
            else if (int.Parse(ViewBag.Provincia) == 5)
            {
                ViewBag.Provincia = "Heredia";
            }
            else
            {
                ViewBag.Provincia = "Cartago";
            }
            int edadNumero = Int32.Parse(edad);

            try
            {
                usuariosConeccion(nombre, cedula, edadNumero, correo, profecion, provincia, canton, distrito);

                return View("confirmacionFormulario");
            }
            catch (Exception)
            {
                return View("error");
                throw;
            }



        }
        public ActionResult foro()
        {
            return View();
        }


    }
}