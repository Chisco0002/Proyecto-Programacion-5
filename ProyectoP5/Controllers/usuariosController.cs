using ProyectoP5.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoP5.Clases;

namespace ProyectoP5.Controllers
{

    public class usuarios : Controller
    {
        Clases.correosControl indi = new Clases.correosControl();
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        private proyectoProgramacionVEntities3 db = new proyectoProgramacionVEntities3();

        public DataSet usuarioDataSet;


        protected void usuariosConnection(string nombreUsuario, string cedulaUsuario,
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

        public ActionResult estudiante(FormCollection form)
        {
            var nombre = form["txtNombre"];
            var cedula = form["txtCedula"];
            var edad = form["txtEdad"];
            var correo = form["txtCorreo"];
            var profesion = form["txtProfesion"];
            var provincia = form["Provincia"];
            var canton = form["txtCanton"];
            var distrito = form["txtDistrito"];


            ViewBag.Nombre = nombre;
            ViewBag.cedula = cedula;
            ViewBag.edad = edad;
            ViewBag.Correo = correo;
            ViewBag.profesion = profesion;
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
            usuariosConnection(nombre, cedula, edadNumero, correo, profesion, provincia, canton, distrito);

            return View("confirmacionFormulario");
        }
    }

}