using System;
using System.Web.UI;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Web.Mvc;
using ProyectoP5.Models;

namespace ProyectoP5.Clases
{
	public class correosControl
	{
			DateTime fechaF = DateTime.Today;		
			private string body2;
			private int dias;
			string bodyCompleto = "<h1>Aquí tienes un resumen de El Progreso de los últimos días</h1><hr>";
			int id;

			public void Page_Load()
			{
				DataSet ds = new DataSet();
				//Traida de datos de la base de datos.
				ds = consultarBaseDeDatos("SELECT id, nombreUsuario, correoUsuario, DATEDIFF ( d , ultimoRegistro , GETDATE() )   as fecha  FROM usuarios where ultimoRegistro <= GETDATE(); ");
				DataTable dt = ds.Tables[0];

				foreach (DataRow row in dt.Rows)
				{
					id = Convert.ToInt32(row["id"]);
					string Correo = Convert.ToString(row["correoUsuario"]);
					string Nombre = Convert.ToString(row["nombreUsuario"]);
					dias = Convert.ToInt32(row["fecha"]);
					actualizarFecha();
					cuerpoCorreo();
					EnviaCorreo(Correo, Nombre);
				}

			}

		public void actualizarFecha()
		{
			DataSet ds = new DataSet();
			//Traida de datos de la base de datos.
			ds = consultarBaseDeDatos("UPDATE [dbo].[Usuarios]  SET[ultimoRegistro] = GETDATE() WHERE id = " + id + "");
			
		}

		//envia correo utilizando el servidor SMTP de gmail, se puede modificar por cualquier otro.
		public void EnviaCorreo(String Correo, String Nombre)
			{
				//modificar la direccion por una cuenta de correo de gmail, preferiblemente una creada para pruebas nada mas
				var fromAddress = new MailAddress("elprogreso333@gmail.com", "El Progreso");
				var toAddress = new MailAddress(Correo, "To Name");
				//Agregar contrasenia del correo
				const string fromPassword = "Nomelase69";
				const string subject = "Informe:";
				string body = bodyCompleto + Nombre;

				var smtp = new SmtpClient
				{
					Host = "smtp.gmail.com",
					Port = 587,
					EnableSsl = true,
					DeliveryMethod = SmtpDeliveryMethod.Network,
					UseDefaultCredentials = false,
					Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
				};
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                    IsBodyHtml = true,
					Subject = subject,
					Body = body
				})
				{
					smtp.Send(message);
				}

			}

			//Se debe sustituir este metodo por el acceso a la base de datos con EF, de forma que lo que reciba sea el nombre del 
			// stored procedure respectivo para consulta de informacion
			public DataSet consultarBaseDeDatos(String consultaSQL)

			{
				//MODIFICAR string de conexion o en su defecto a EF
				SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=proyectoProgramacionV;Integrated Security=True");
				conexion.Open();
				SqlCommand cmd = new SqlCommand(consultaSQL, conexion);
				SqlDataAdapter sda = new SqlDataAdapter(cmd);
				DataSet ds = new DataSet();
				sda.Fill(ds);
				conexion.Close();
				return ds;
			}

			protected void cuerpoCorreo()
			{
				DataSet ds = new DataSet();
				DataTable dt = new DataTable();
				
			//Traida de datos de la base de datos.
			for (int i = 0; i <= dias; i++)
				{
					string sql = "select b.numvalor, p.numvalor, c.numValor, v.numValor, b.desFecha from tasaBasicaPasiva b,	tasaDePolíticaMonetaria p,	 tipoDeCambioCompra c, tipoDeCambioVenta v where b.desFecha <= DATEADD(day,-" + i + ", GETDATE())  and b.desFecha >= DATEADD(day, -" + (i+1) + ", GETDATE())  and b.desFecha = p.desFecha  and b.desFecha = c.desFecha  and b.desFecha = v.desFecha";

					ds = consultarBaseDeDatos(sql);
					dt = ds.Tables[0];

                
					
				foreach (DataRow row in dt.Rows)
					{
						string basicaPasiva = Convert.ToString(row["numvalor"]);
						string politicaMonetaria = Convert.ToString(row["numvalor1"]);
						string compra = Convert.ToString(row["numValor2"]);
						string venta = Convert.ToString(row["numValor3"]);
						DateTime fecha = Convert.ToDateTime(row["desFecha"]);

						body2 = "<h1>Fecha: " + fecha.ToShortDateString() + "</h1><br>" +
                                    "<p>Tasa Básica Pasiva: " + basicaPasiva + "</p>" +
                                    "<p>Tasa Política Monetaria: " + politicaMonetaria + "</p>" +
                                    "<p>Tipo de cambio de compra del dolár: " + compra + "</p>" +
									"<p>Tipo de cambio de venta del dolár: " + venta + "</p><br>";

					
					}
				 bodyCompleto= bodyCompleto +body2;

				}
						}

		}
	}
