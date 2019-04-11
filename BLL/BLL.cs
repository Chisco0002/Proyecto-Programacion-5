using System;
using System.Data;
using System.Data.SqlClient;
using DAL;



namespace BLL
{
	public class Productos
	{
		
		
		
		
		#region Metodos muestra

		public DataSet carga_lista_productos()
		{
			conexion = cls_DAL.trae_conexion("proyectoProgramacionV", ref mensaje_error, ref numero_error);
			if (conexion == null)
			{
				
				return null;
			}
			else
			{
				sql = "Select Cod_Producto as Codigo,Nombre_Producto as Nombre,Descontinuado as Descontinuado" +
					" from Productos " +
					" order by Cod_Producto";
				ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
				if (numero_error != 0)
				{
				
					return null;
				}
				else
				{
					return ds;
				}
			}
		}

		public DataSet carga_lineas()
		{
			conexion = cls_DAL.trae_conexion("Progra", ref mensaje_error, ref numero_error);
			if (conexion == null)
			{
				
				return null;
			}
			else
			{
				sql = "Select Cod_Linea,Descripcion_Linea" +
					" from Lineas " +
					" order by Cod_Linea";
				ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
				if (numero_error != 0)
				{
					
					return null;
				}
				else
				{
					return ds;
				}
			}
		}


		public DataSet carga_proveedores()
		{
			conexion = cls_DAL.trae_conexion("Progra", ref mensaje_error, ref numero_error);
			if (conexion == null)
			{
				
				return null;
			}
			else
			{
				sql = "Select Cod_Proveedor,Nombre_Proveedor" +
					" from Proveedores " +
					" order by Cod_Proveedor";
				ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
				if (numero_error != 0)
				{
					
					return null;
				}
				else
				{
					return ds;
				}
			}
		}

		public bool guarda_producto(string accion)
		{

			conexion = cls_DAL.trae_conexion("proyectoProgramacionV", ref mensaje_error, ref numero_error);
			if (conexion == null)
			{
				
				return false;
			}
			else
			{
				if (accion.Equals("Insertar"))
				{
					sql = "INSERT INTO indicadoor(Espacio1, Espacio2, Espacio3) VALUES ('hjk','fds','asd')";
				}
				else
				{
					//sql = "Update Productos set" +
					//	" Nombre_Producto=@nombre," +
					//	" Cod_Linea=@Cod_linea" +
					//	" Cod_Proveedor=@cod_proveedor" +
					//	" Descontinuado=@descontinuado" +
					//	" where Cod_Producto=@cod";
				}
				ParamStruct[] parametros = new ParamStruct[5];

				//cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@id_categoryM", SqlDbType.Int, _ID_Category);
				//cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@NameM", SqlDbType.VarChar, _Name);
				//cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@last_nameM", SqlDbType.VarChar, _lastName);
				//cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@addressM", SqlDbType.VarChar, _Address);
				//cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@emailM", SqlDbType.VarChar, _Email);

				cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
				//Colocar siempre la var de parametros de esta forma se prodra insertar o actualizar
				cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
				if (numero_error != 0)
				{
					
					cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
					return false;
				}
				else
				{
					cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
					return true;
				}
			}

		}


		public bool eliminar_producto(int cod_producto)
		{

			conexion = cls_DAL.trae_conexion("Progra", ref mensaje_error, ref numero_error);
			if (conexion == null)
			{
				
				return false;
			}
			else
			{
				sql = "Delete from Productos where cod_producto =@cod";
				ParamStruct[] parametros = new ParamStruct[1];


				cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod", SqlDbType.Int, cod_producto);

				cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
				//Colocar siempre la var de parametros de esta forma se prodra insertar o actualizar
				cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
				if (numero_error != 0)
				{
					
					cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
					return false;
				}
				else
				{
					cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
					return true;
				}
			}

		}

		public void carga_info_productos(int cod_producto)
		{

			conexion = cls_DAL.trae_conexion("Progra", ref mensaje_error, ref numero_error);
			if (conexion == null)
			{
				
				
			}
			else
			{
				sql = "Select Nombre_Producto, Cod_Linea, Cod_Proveedor, Descontinuado " +
					" from Productos where cod_producto =@cod";
				ParamStruct[] parametros = new ParamStruct[1];


				cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod", SqlDbType.Int, cod_producto);

				cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
				//Colocar siempre la var de parametros de esta forma se prodra insertar o actualizar
				ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
				if (ds == null)
				{
					
				}
				else
				{
					if (ds.Tables[0].Rows.Count > 0)
					{
						
					}
					else
					{
						;
					}
				}
			}

		}
		#endregion
		#region Variables
		SqlConnection conexion;
		DataSet ds;
		string sql = string.Empty;
		string mensaje_error = string.Empty;
		int numero_error = 0;
		#endregion
	}
}
