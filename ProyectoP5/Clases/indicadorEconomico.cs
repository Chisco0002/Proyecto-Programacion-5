using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Web.Mvc;
using ProyectoP5.Models;

namespace ProyectoP5.Clases
{

    public class indicadorEconomico
    {
        private proyectoProgramacionVEntities3 db = new proyectoProgramacionVEntities3();
        cr.fi.bccr.gee.wsIndicadoresEconomicos indicadorConsulta = new cr.fi.bccr.gee.wsIndicadoresEconomicos();


        string stringConn = System.Configuration.ConfigurationManager.
    ConnectionStrings["ProyectoP5.Properties.Settings.proyectoProgramacionV"].ConnectionString;

        //INDICADORES PARA EL PROYECTO
        //Tipo de cambio venta: 318
        //Tipo de cambio compra: 317
        //Tasa de política monetaria: 3541
        //Tasa Basica pasiva: 423

        //DataSets utilizados para el almacenamiento de los datos
        public DataSet tipoDeCambioVentaDataSet;
        public DataSet tipoDeCambioCompraDataSet;
        public DataSet tasaDePoliticaMonetariaDataSet;
        public DataSet tasaBasicaPasivaDataSet;

        //TODO Ajustar fecha inicial
        DateTime fechaI = DateTime.Today.AddYears(-5);

        DateTime fechaF = DateTime.Today;


        //Codigo Indicador  indicadorEconomicoDataSet.Tables[0].Rows[0].ItemArray[0].ToString();
        //Fecha Consulta    indicadorEconomicoDataSet.Tables[0].Rows[0].ItemArray[1].ToString();
        //Codigo Consultado indicadorEconomicoDataSet.Tables[0].Rows[0].ItemArray[2].ToString();


        //Falta Modificar las fechas para hacer que traiga los datos del día en especifico(hoy)


        ////// Venta
        public void tipoDeCambioVenta()
        {
            try
            {

                tipoDeCambioVentaDataSet = indicadorConsulta.ObtenerIndicadoresEconomicos("318", fechaI.ToShortDateString(), fechaF.ToShortDateString(), "Marco", "N");

                foreach (DataTable table in tipoDeCambioVentaDataSet.Tables)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        string codIndicador = dr[0].ToString();
                        DateTime desFecha = Convert.ToDateTime(dr[1]);
                        string numValor = dr[2].ToString();

                        tipoDeCambioVentaConeccion(codIndicador, desFecha, numValor);
                    }

                }
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }




        }

        protected void tipoDeCambioVentaConeccion(string codIndicador, DateTime desFecha, string numValor)
        {

            SqlConnection con = new SqlConnection(@stringConn);
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

        ////// Compra
        public void tipoDeCambioCompra()
        {

            try
            {
                tipoDeCambioCompraDataSet = indicadorConsulta.ObtenerIndicadoresEconomicos("317", fechaI.ToShortDateString(), fechaF.ToShortDateString(), "Marco", "N");

                foreach (DataTable table in tipoDeCambioCompraDataSet.Tables)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        string codIndicador = dr[0].ToString();
                        DateTime desFecha = Convert.ToDateTime(dr[1]);
                        string numValor = dr[2].ToString();

                        tipoDeCambioCompraConeccion(codIndicador, desFecha, numValor);
                    }

                }

            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }

        }

        protected void tipoDeCambioCompraConeccion(string codIndicador, DateTime desFecha, string numValor)
        {

            SqlConnection con = new SqlConnection(@stringConn);
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


        ////// Tasa basica pasiva
        public void tasaBasicaPasiva()
        {

            try
            {
                tasaBasicaPasivaDataSet = indicadorConsulta.ObtenerIndicadoresEconomicos("423", fechaI.ToShortDateString(), fechaF.ToShortDateString(), "Marco", "N");

                foreach (DataTable table in tasaBasicaPasivaDataSet.Tables)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        string codIndicador = dr[0].ToString();
                        DateTime desFecha = Convert.ToDateTime(dr[1]);
                        string numValor = dr[2].ToString();

                        tasaBasicaPasivaConeccion(codIndicador, desFecha, numValor);
                    }

                }

            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }

        }


        protected void tasaBasicaPasivaConeccion(string codIndicador, DateTime desFecha, string numValor)
        {

            SqlConnection con = new SqlConnection(@stringConn);
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



        ////// Tasa politica monetaria
        public void tasaDePoliticaMonetaria()
        {

            try
            {

                tasaDePoliticaMonetariaDataSet = indicadorConsulta.ObtenerIndicadoresEconomicos("3541", fechaI.ToShortDateString(), fechaF.ToShortDateString(), "Marco", "N");

                foreach (DataTable table in tasaDePoliticaMonetariaDataSet.Tables)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        string codIndicador = dr[0].ToString();
                        DateTime desFecha = Convert.ToDateTime(dr[1]);
                        string numValor = dr[2].ToString();

                        tasaDePoliticaMonetariaConeccion(codIndicador, desFecha, numValor);
                    }

                }
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }

        }

        protected void tasaDePoliticaMonetariaConeccion(string codIndicador, DateTime desFecha, string numValor)
        {
            SqlConnection con = new SqlConnection(@stringConn);
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
    }
}