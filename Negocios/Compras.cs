using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Practico.Clases;
using System.Windows.Forms;

namespace Practico.Negocios
{
    class Compras
    {
		BaseDatos baseDatos = new BaseDatos();

        public void InsertarCompra(string fecha, string tipoDocProveedor, string nroDocProveedor, Grid01 detalles)
        {
            baseDatos.IniciarTransaccion();

            TratamientosEspeciales tratamientos = new TratamientosEspeciales();
            int nroComprobante = baseDatos.nextAutoincrement("Compras");

            string actualizarStock;

            string insertCompra = "INSERT INTO Compras (fecha, tipoDocProveedor, nroDocProveedor) VALUES";
            insertCompra += "(" + baseDatos.FormatearDato(fecha, "Date") + "," + tipoDocProveedor + ",'" + nroDocProveedor + "')";

            baseDatos.Insertar(insertCompra);


            string insertDetalle =
                @"INSERT INTO DetallesCompras (nroComprobante, tipoDocProveedor, nroDocProveedor, idHelado, cantKilos) VALUES (";

            for (int i = 0; i < detalles.Rows.Count; i++)
            {
                string idHelado = detalles.Rows[i].Cells[1].Value.ToString();
                string cantKilos = detalles.Rows[i].Cells[4].Value.ToString();
                
                
                string datosDetalle = nroComprobante.ToString();
                datosDetalle += "," + tipoDocProveedor;
                datosDetalle += "," + nroDocProveedor;
                datosDetalle += "," + idHelado;
                datosDetalle += "," + cantKilos;

                actualizarStock = "UPDATE Helados " +
                                  " SET cantidadStock += " + cantKilos +
                                  " WHERE idHelado =" + idHelado;
                baseDatos.Actualizar(actualizarStock);
                   
                datosDetalle += ")";

                string insertFinal = insertDetalle + datosDetalle;
                baseDatos.Insertar(insertFinal);
            }

            if (baseDatos.CerrarTransaccion() == BaseDatos.EstadoTransaccion.correcta)
            {
                MessageBox.Show("Transaccion realizada con exito!", "Informacion",
                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error con la transaccion!", "Error",
                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }

        }

        public DataTable RecuperarCompra(string nroComprobante)
		{
            DataTable tabla = new DataTable();
			string sql = @"	SELECT nroComprobante, 
			                    CONVERT(varchar, fecha, 103) as fecha,
								tipoDocProveedor,
								nroDocProveedor,
								razonSocial,
			                    SUM(Total) as SumTotal
	                            FROM (
		                                SELECT	C.nroComprobante,
				                                C.fecha,
				                                C.tipoDocProveedor,
				                                C.nroDocProveedor,
				                                P.razonSocial, 
				                                SUM( D.cantKilos * PH.precio) as Total
		                                FROM Compras C
			                                INNER JOIN Proveedores P ON (C.tipoDocProveedor = P.tipoDocumento) AND (C.nroDocProveedor = P.nroDocumento)
			                                INNER JOIN DetallesCompras D ON (C.nroComprobante = D.nroComprobante)
			                                INNER JOIN ProveedoresHelados PH ON (D.tipoDocProveedor = PH.tipoDocProveedor)	
																			  AND (D.nroDocProveedor = PH.nroDocProveedor) 
																		      AND (D.idHelado = PH.idHelado)
		                                GROUP BY C.nroComprobante, C.fecha, C.tipoDocProveedor, C.nroDocProveedor, P.razonSocial) AS Resultado
	                                WHERE ";
			sql += "NroComprobante = '" + nroComprobante + "'";
			sql += " GROUP BY nroComprobante, fecha, tipoDocProveedor, nroDocProveedor, razonSocial";

			tabla = baseDatos.Consulta(sql);
			return tabla;
		}

		public DataTable RecuperarCompra(string fechaDesde, string fechaHasta)
		{
			DataTable tabla = new DataTable();
			string sql = @"	SELECT nroComprobante, 
			                    CONVERT(varchar, fecha, 103) as fecha,
								tipoDocProveedor,
								nroDocProveedor,
								razonSocial,
			                    SUM(Total) as SumTotal
	                            FROM (
		                                SELECT	C.nroComprobante,
				                                C.fecha,
				                                C.tipoDocProveedor,
				                                C.nroDocProveedor,
				                                P.razonSocial, 
				                                SUM( D.cantKilos * PH.precio) as Total
		                                FROM Compras C
			                                INNER JOIN Proveedores P ON (C.tipoDocProveedor = P.tipoDocumento) AND (C.nroDocProveedor = P.nroDocumento)
			                                INNER JOIN DetallesCompras D ON (C.nroComprobante = D.nroComprobante)
			                                INNER JOIN ProveedoresHelados PH ON (D.tipoDocProveedor = PH.tipoDocProveedor)	
																			  AND (D.nroDocProveedor = PH.nroDocProveedor) 
																		      AND (D.idHelado = PH.idHelado)
		                                GROUP BY C.nroComprobante, C.fecha, C.tipoDocProveedor, C.nroDocProveedor, P.razonSocial) AS Resultado
	                                WHERE ";
			sql += " fecha BETWEEN CONVERT(date,'" + fechaDesde +
				   "',103) AND CONVERT(date,'" + fechaHasta + "',103)";
			sql += " GROUP BY nroComprobante, fecha, tipoDocProveedor, nroDocProveedor, razonSocial";

			tabla = baseDatos.Consulta(sql);
			return tabla;
		}

		public DataTable RecuperarCompra(string tipoDocProveedor, string nroDocProveedor, string razonSocial)
		{
			DataTable tabla = new DataTable();
			string sql = @"	SELECT nroComprobante, 
			                    CONVERT(varchar, fecha, 103) as fecha,
								tipoDocProveedor,
								nroDocProveedor,
								razonSocial,
			                    SUM(Total) as SumTotal
	                            FROM (
		                                SELECT	C.nroComprobante,
				                                C.fecha,
				                                C.tipoDocProveedor,
				                                C.nroDocProveedor,
				                                P.razonSocial, 
				                                SUM( D.cantKilos * PH.precio) as Total
		                                FROM Compras C
			                                INNER JOIN Proveedores P ON (C.tipoDocProveedor = P.tipoDocumento) AND (C.nroDocProveedor = P.nroDocumento)
			                                INNER JOIN DetallesCompras D ON (C.nroComprobante = D.nroComprobante)
			                                INNER JOIN ProveedoresHelados PH ON (D.tipoDocProveedor = PH.tipoDocProveedor)	
																			  AND (D.nroDocProveedor = PH.nroDocProveedor) 
																		      AND (D.idHelado = PH.idHelado)
		                                GROUP BY C.nroComprobante, C.fecha, C.tipoDocProveedor, C.nroDocProveedor, P.razonSocial) AS Resultado
	                                WHERE ";
			sql += "tipoDocProveedor =" + tipoDocProveedor + " AND nroDocProveedor LIKE '" + nroDocProveedor + "'" +
					   " AND razonSocial LIKE '" + razonSocial + "'";
			sql += " GROUP BY nroComprobante, fecha, tipoDocProveedor, nroDocProveedor, razonSocial";

			tabla = baseDatos.Consulta(sql);
			return tabla;
		}

        public DataTable RecuperarCompra1(string nroComprobante, string fechaDesde, string fechaHasta)
        {
            DataTable tabla = new DataTable();
            string sql = @"	SELECT nroComprobante, 
			                    CONVERT(varchar, fecha, 103) as fecha,
								tipoDocProveedor,
								nroDocProveedor,
								razonSocial,
			                    SUM(Total) as SumTotal
	                            FROM (
		                                SELECT	C.nroComprobante,
				                                C.fecha,
				                                C.tipoDocProveedor,
				                                C.nroDocProveedor,
				                                P.razonSocial, 
				                                SUM( D.cantKilos * PH.precio) as Total
		                                FROM Compras C
			                                INNER JOIN Proveedores P ON (C.tipoDocProveedor = P.tipoDocumento) AND (C.nroDocProveedor = P.nroDocumento)
			                                INNER JOIN DetallesCompras D ON (C.nroComprobante = D.nroComprobante)
			                                INNER JOIN ProveedoresHelados PH ON (D.tipoDocProveedor = PH.tipoDocProveedor)	
																			  AND (D.nroDocProveedor = PH.nroDocProveedor) 
																		      AND (D.idHelado = PH.idHelado)
		                                GROUP BY C.nroComprobante, C.fecha, C.tipoDocProveedor, C.nroDocProveedor, P.razonSocial) AS Resultado
	                                WHERE ";
            sql += "NroComprobante = '" + nroComprobante + "'";
            sql += " AND fecha BETWEEN CONVERT(date,'" + fechaDesde +
                       "',103) AND CONVERT(date,'" + fechaHasta + "',103)";
            sql += " GROUP BY nroComprobante, fecha, tipoDocProveedor, nroDocProveedor, razonSocial";

            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public DataTable RecuperarCompra2(string tipoDocProveedor, string nroDocProveedor, string razonSocial, string fechaDesde, string fechaHasta)
        {
            DataTable tabla = new DataTable();
            string sql = @"	SELECT nroComprobante, 
        	                    CONVERT(varchar, fecha, 103) as fecha,
        						tipoDocProveedor,
        						nroDocProveedor,
        						razonSocial,
        	                    SUM(Total) as SumTotal
                                   FROM (
                                        SELECT	C.nroComprobante,
        		                                C.fecha,
        		                                C.tipoDocProveedor,
        		                                C.nroDocProveedor,
        		                                P.razonSocial, 
        		                                SUM( D.cantKilos * PH.precio) as Total
                                        FROM Compras C
        	                                INNER JOIN Proveedores P ON (C.tipoDocProveedor = P.tipoDocumento) AND (C.nroDocProveedor = P.nroDocumento)
        	                                INNER JOIN DetallesCompras D ON (C.nroComprobante = D.nroComprobante)
        	                                INNER JOIN ProveedoresHelados PH ON (D.tipoDocProveedor = PH.tipoDocProveedor)	
        																	  AND (D.nroDocProveedor = PH.nroDocProveedor) 
        																      AND (D.idHelado = PH.idHelado)
                                        GROUP BY C.nroComprobante, C.fecha, C.tipoDocProveedor, C.nroDocProveedor, P.razonSocial) AS Resultado
                                       WHERE ";
            sql += "tipoDocProveedor =" + tipoDocProveedor + " AND nroDocProveedor LIKE '" + nroDocProveedor + "'" +
                       " AND razonSocial LIKE '" + razonSocial + "'";
            sql += " AND fecha BETWEEN CONVERT(date,'" + fechaDesde +
                       "',103) AND CONVERT(date,'" + fechaHasta + "',103)";
            sql += " GROUP BY nroComprobante, fecha, tipoDocProveedor, nroDocProveedor, razonSocial";

            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

		public DataTable RecuperarCompra3(string nroComprobante, string tipoDocProveedor, string nroDocProveedor, string razonSocial)
		{
			DataTable tabla = new DataTable();
			string sql = @"	SELECT nroComprobante, 
        	                    CONVERT(varchar, fecha, 103) as fecha,
        						tipoDocProveedor,
        						nroDocProveedor,
        						razonSocial,
        	                    SUM(Total) as SumTotal
                                   FROM (
                                        SELECT	C.nroComprobante,
        		                                C.fecha,
        		                                C.tipoDocProveedor,
        		                                C.nroDocProveedor,
        		                                P.razonSocial, 
        		                                SUM( D.cantKilos * PH.precio) as Total
                                        FROM Compras C
        	                                INNER JOIN Proveedores P ON (C.tipoDocProveedor = P.tipoDocumento) AND (C.nroDocProveedor = P.nroDocumento)
        	                                INNER JOIN DetallesCompras D ON (C.nroComprobante = D.nroComprobante)
        	                                INNER JOIN ProveedoresHelados PH ON (D.tipoDocProveedor = PH.tipoDocProveedor)	
        																	  AND (D.nroDocProveedor = PH.nroDocProveedor) 
        																      AND (D.idHelado = PH.idHelado)
                                        GROUP BY C.nroComprobante, C.fecha, C.tipoDocProveedor, C.nroDocProveedor, P.razonSocial) AS Resultado
                                       WHERE ";
			sql += "NroComprobante = '" + nroComprobante + "'";
			sql += " AND tipoDocProveedor =" + tipoDocProveedor + " AND nroDocProveedor LIKE '" + nroDocProveedor + "'" +
					   " AND razonSocial LIKE '" + razonSocial + "'";
			sql += " GROUP BY nroComprobante, fecha, tipoDocProveedor, nroDocProveedor, razonSocial";

			tabla = baseDatos.Consulta(sql);
			return tabla;
		}

		public DataTable RecuperarCompra4(string nroComprobante, string fechaDesde, string fechaHasta, string tipoDocProveedor, string nroDocProveedor, string razonSocial)
		{
			DataTable tabla = new DataTable();
			string sql = @"	SELECT nroComprobante, 
        	                    CONVERT(varchar, fecha, 103) as fecha,
        						tipoDocProveedor,
        						nroDocProveedor,
        						razonSocial,
        	                    SUM(Total) as SumTotal
                                   FROM (
                                        SELECT	C.nroComprobante,
        		                                C.fecha,
        		                                C.tipoDocProveedor,
        		                                C.nroDocProveedor,
        		                                P.razonSocial, 
        		                                SUM( D.cantKilos * PH.precio) as Total
                                        FROM Compras C
        	                                INNER JOIN Proveedores P ON (C.tipoDocProveedor = P.tipoDocumento) AND (C.nroDocProveedor = P.nroDocumento)
        	                                INNER JOIN DetallesCompras D ON (C.nroComprobante = D.nroComprobante)
        	                                INNER JOIN ProveedoresHelados PH ON (D.tipoDocProveedor = PH.tipoDocProveedor)	
        																	  AND (D.nroDocProveedor = PH.nroDocProveedor) 
        																      AND (D.idHelado = PH.idHelado)
                                        GROUP BY C.nroComprobante, C.fecha, C.tipoDocProveedor, C.nroDocProveedor, P.razonSocial) AS Resultado
                                       WHERE ";
			sql += "NroComprobante = '" + nroComprobante + "'";
			sql += " AND fecha BETWEEN CONVERT(date,'" + fechaDesde +
					   "',103) AND CONVERT(date,'" + fechaHasta + "',103)";
			sql += " AND tipoDocProveedor =" + tipoDocProveedor + " AND nroDocProveedor LIKE '" + nroDocProveedor + "'" +
					   " AND razonSocial LIKE '" + razonSocial + "'";
			sql += " GROUP BY nroComprobante, fecha, tipoDocProveedor, nroDocProveedor, razonSocial";

			tabla = baseDatos.Consulta(sql);
			return tabla;
		}

		public DataTable RecuperarTodasLasCompras()
		{
			DataTable tabla = new DataTable();
			string sql = @"	SELECT nroComprobante, 
        	                    CONVERT(varchar, fecha, 103) as fecha,
        						tipoDocProveedor,
        						nroDocProveedor,
        						razonSocial,
        	                    SUM(Total) as SumTotal
                                   FROM (
                                        SELECT	C.nroComprobante,
        		                                C.fecha,
        		                                C.tipoDocProveedor,
        		                                C.nroDocProveedor,
        		                                P.razonSocial, 
        		                                SUM( D.cantKilos * PH.precio) as Total
                                        FROM Compras C
        	                                INNER JOIN Proveedores P ON (C.tipoDocProveedor = P.tipoDocumento) AND (C.nroDocProveedor = P.nroDocumento)
        	                                INNER JOIN DetallesCompras D ON (C.nroComprobante = D.nroComprobante)
        	                                INNER JOIN ProveedoresHelados PH ON (D.tipoDocProveedor = PH.tipoDocProveedor)	
        																	  AND (D.nroDocProveedor = PH.nroDocProveedor) 
        																      AND (D.idHelado = PH.idHelado)
                                        GROUP BY C.nroComprobante, C.fecha, C.tipoDocProveedor, C.nroDocProveedor, P.razonSocial) AS Resultado";
			sql += " GROUP BY nroComprobante, fecha, tipoDocProveedor, nroDocProveedor, razonSocial";

			tabla = baseDatos.Consulta(sql);
			return tabla;
		}

         public DataTable EstadisticaCantidadComprasProveedor()
            {
                string sql = @"SELECT P.razonSocial as RazonSocial, COUNT(*) AS Cantidad
                                FROM Compras C
                                INNER JOIN Proveedores P ON (C.tipoDocProveedor = P.tipoDocumento) AND (C.nroDocProveedor = P.nroDocumento)
                                GROUP BY P.razonSocial";

                DataTable tabla = new DataTable();
                tabla = baseDatos.Consulta(sql);
                return tabla;
            }
         public DataTable EstadisticaCantidadComprasProveedorPeriodo(DateTime fechaDesde, DateTime fechaHasta)
            {
                string sql = @"SELECT P.razonSocial as RazonSocial, COUNT(*) AS Cantidad
                                FROM Compras C
                                INNER JOIN Proveedores P ON (C.tipoDocProveedor = P.tipoDocumento) AND (C.nroDocProveedor = P.nroDocumento)
                               WHERE C.fecha BETWEEN CONVERT(datetime, '" + fechaDesde.ToShortDateString()+"', 103) AND CONVERT(datetime, '"+ fechaHasta.ToShortDateString()+"', 103)"+
                              " GROUP BY P.razonSocial";

            DataTable tabla = new DataTable();
                tabla = baseDatos.Consulta(sql);
                return tabla;
            }

	}
}