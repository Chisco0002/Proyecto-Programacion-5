using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;
using ProyectoP5.Models;

namespace ProyectoP5.Clases
{

	public class indicadorEconomico
	{
		private proyectoProgramacionVEntities3 db = new proyectoProgramacionVEntities3();
		cr.fi.bccr.gee.wsIndicadoresEconomicos indicadorConsulta = new cr.fi.bccr.gee.wsIndicadoresEconomicos();

		//DataSets utilizados para el almacenamiento de los datos
		public DataSet tipoDeCambioVentaDataSet;
		public DataSet tipoDeCambioCompraDataSet;
		public DataSet tasaDePoliticaMonetariaDataSet;
		public DataSet tasaBasicaPasivaDataSet;
		
		//Codigo Indicador  indicadorEconomicoDataSet.Tables[0].Rows[0].ItemArray[0].ToString();
		//Fecha Consulta    indicadorEconomicoDataSet.Tables[0].Rows[0].ItemArray[1].ToString();
		//Codigo Consultado indicadorEconomicoDataSet.Tables[0].Rows[0].ItemArray[2].ToString();
		
			
			//Falta Modificar las fechas para hacer que traiga los datos del día en especifico(hoy)

		protected void tipoDeCambioVentaConeccion(string codIndicador, string desFecha, string numValor)
		{

			SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=proyectoProgramacionV;Integrated Security=True");
			SqlCommand cmd = new SqlCommand("insertar_tipoDeCambioVenta", con);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("codIndicador", codIndicador);
			cmd.Parameters.AddWithValue("desFecha", desFecha);
			cmd.Parameters.AddWithValue("numValor", numValor);			
			
			con.Open();
			int k = cmd.ExecuteNonQuery();
			if (k != 0)
			{
			}
			con.Close();
		}
		public void tipoDeCambioVenta() {
			
			tipoDeCambioVentaDataSet = indicadorConsulta.ObtenerIndicadoresEconomicos("318", "01/04/2019", "01/04/2019", "Francisco", "N");
			String codIndicador = tipoDeCambioVentaDataSet.Tables[0].Rows[0].ItemArray[0].ToString(); 
			String desFecha = tipoDeCambioVentaDataSet.Tables[0].Rows[0].ItemArray[1].ToString(); 
			String numValor = tipoDeCambioVentaDataSet.Tables[0].Rows[0].ItemArray[2].ToString();
			tipoDeCambioVentaConeccion(codIndicador, desFecha, numValor);
			

		}


		protected void tipoDeCambioCompraConeccion(string codIndicador, string desFecha, string numValor)
		{

			SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=proyectoProgramacionV;Integrated Security=True");
			SqlCommand cmd = new SqlCommand("insertar_tipoDeCambioCompra", con);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("codIndicador", codIndicador);
			cmd.Parameters.AddWithValue("desFecha", desFecha);
			cmd.Parameters.AddWithValue("numValor", numValor);

			con.Open();
			int k = cmd.ExecuteNonQuery();
			if (k != 0)
			{
			}
			con.Close();
		}
		public void tipoDeCambioCompra()
		{
            //DateTime fechaI = DateTime.Today.AddDays(-1095);
            //DateTime fechaF = DateTime.Today;
            //for (DateTime i = fechaI; i < fechaF; i = i.AddDays(1))
            //{
            //    tipoDeCambioCompraDataSet = indicadorConsulta.ObtenerIndicadoresEconomicos("317", i.ToShortDateString(), i.ToShortDateString(), "Francisco", "N");
            //    String codIndicador = tipoDeCambioCompraDataSet.Tables[0].Rows[0].ItemArray[0].ToString();
            //    String desFecha = tipoDeCambioCompraDataSet.Tables[0].Rows[0].ItemArray[1].ToString();
            //    String numValor = tipoDeCambioCompraDataSet.Tables[0].Rows[0].ItemArray[2].ToString();
            //    tipoDeCambioCompraConeccion(codIndicador, desFecha, numValor);
            //}
        }

		protected void tasaDePoliticaMonetariaConeccion(string codIndicador, string desFecha, string numValor)
		{
			SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=proyectoProgramacionV;Integrated Security=True");
			SqlCommand cmd = new SqlCommand("insertar_tasaDePolíticaMonetaria", con);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("codIndicador", codIndicador);
			cmd.Parameters.AddWithValue("desFecha", desFecha);
			cmd.Parameters.AddWithValue("numValor", numValor);

			con.Open();
			int k = cmd.ExecuteNonQuery();
			if (k != 0)
			{
			}
			con.Close();
		}
		public void tasaDePoliticaMonetaria()
		{
   //         DateTime fechaI = DateTime.Today.AddDays(-1095);
   //         DateTime fechaF = DateTime.Today;
   //         for (DateTime i = fechaI; i < fechaF; i = i.AddDays(1))
   //         {
			//tasaDePoliticaMonetariaDataSet = indicadorConsulta.ObtenerIndicadoresEconomicos("317", i.ToShortDateString(), i.ToShortDateString(), "Francisco", "N");
			//String codIndicador = tasaDePoliticaMonetariaDataSet.Tables[0].Rows[0].ItemArray[0].ToString();
			//String desFecha = tasaDePoliticaMonetariaDataSet.Tables[0].Rows[0].ItemArray[1].ToString();
			//String numValor = tasaDePoliticaMonetariaDataSet.Tables[0].Rows[0].ItemArray[2].ToString();
			//tasaDePoliticaMonetariaConeccion(codIndicador, desFecha, numValor);
   //         }
        }



		protected void tasaBasicaPasivaConeccion(string codIndicador, string desFecha, string numValor)
		{

			SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=proyectoProgramacionV;Integrated Security=True");
			SqlCommand cmd = new SqlCommand("insertar_tasaBasicaPasiva", con);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("codIndicador", codIndicador);
			cmd.Parameters.AddWithValue("desFecha", desFecha);
			cmd.Parameters.AddWithValue("numValor", numValor);

			con.Open();
			int k = cmd.ExecuteNonQuery();
			if (k != 0)
			{
			}
			con.Close();
		}
		public void tasaBasicaPasiva()
		{
            //DateTime fechaI = DateTime.Today.AddDays(-1095);
            //DateTime fechaF = DateTime.Today;
            //for (DateTime i = fechaI; i < fechaF; i = i.AddDays(1))
            //{
            //    tasaBasicaPasivaDataSet = indicadorConsulta.ObtenerIndicadoresEconomicos("423", i.ToShortDateString(), i.ToShortDateString(), "Ignacio", "N");
            //    String codIndicador = tasaBasicaPasivaDataSet.Tables[0].Rows[0].ItemArray[0].ToString();
            //    String desFecha = tasaBasicaPasivaDataSet.Tables[0].Rows[0].ItemArray[1].ToString();
            //    String numValor = tasaBasicaPasivaDataSet.Tables[0].Rows[0].ItemArray[2].ToString();
            //    tasaBasicaPasivaConeccion(codIndicador, desFecha, numValor);
            //}
        }


	}
}