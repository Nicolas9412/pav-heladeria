    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Practico.Clases;

    namespace Practico.Negocios
    {
        class Ventas
        {
            BaseDatos baseDatos = new BaseDatos();

            public void InsertarVenta(string tipoDoc, string nroDoc, Grid01 detalles)
            {
                baseDatos.IniciarTransaccion();

                TratamientosEspeciales tratamientos = new TratamientosEspeciales();
                int nroTicket = baseDatos.nextAutoincrement("Ventas");
                string fecha = baseDatos.Fecha();


                string actualizarStock;

                string insertVenta = "INSERT INTO Ventas (fecha, tipoDocEmpleado, nroDocEmpleado) VALUES";
                insertVenta += "(" + baseDatos.FormatearDato(fecha, "Date") + "," + tipoDoc + ",'" + nroDoc + "')";

                baseDatos.Insertar(insertVenta);


                string insertDetalle =
                    @"INSERT INTO DetalleVentas (nroTicket, idHeladoSimple, cantKilos, idHeladoEspecial, cantItems) VALUES (";

                for (int i = 0; i < detalles.Rows.Count; i++)
                {
                    string idHeladoSimple = detalles.Rows[i].Cells[1].Value.ToString();
                    string cantKilos = detalles.Rows[i].Cells[4].Value.ToString();
                    string idHeladoEspecial = detalles.Rows[i].Cells[1].Value.ToString();
                    string cantItems = detalles.Rows[i].Cells[4].Value.ToString();
                    string esEspecial = detalles.Rows[i].Cells[6].Value.ToString();
                    string nombreHelado = detalles.Rows[i].Cells[2].Value.ToString();


                    string datosDetalle = nroTicket.ToString();


                    if (esEspecial == "false")
                    {
                        datosDetalle += "," + idHeladoSimple;
                        datosDetalle += "," + cantKilos;
                        if (tratamientos.ValidarStock("Helados",
                            cantKilos, idHeladoSimple) == TratamientosEspeciales.Validacion.correcta)
                        {
                            actualizarStock = "UPDATE Helados " +
                                              " SET cantidadStock -= " + cantKilos +
                                              " WHERE idHelado =" + idHeladoSimple;
                            baseDatos.Actualizar(actualizarStock);
                        }
                        else
                        {
                            baseDatos.controlTransaccion = BaseDatos.EstadoTransaccion.error;
                            MessageBox.Show("No hay stock suficiente de " + nombreHelado, "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        datosDetalle += "," + "NULL";
                        datosDetalle += "," + "NULL";
                    }

                    if (esEspecial == "true")
                    {
                        datosDetalle += "," + idHeladoEspecial;
                        datosDetalle += "," + cantItems;
                        if (tratamientos.ValidarStock("HeladosEspeciales",
                            cantItems, idHeladoEspecial) == TratamientosEspeciales.Validacion.correcta)
                        {
                            actualizarStock = "UPDATE HeladosEspeciales " +
                                              " SET cantidadStock -= " + cantItems +
                                              " WHERE idHeladoEspecial =" + idHeladoEspecial;
                            baseDatos.Actualizar(actualizarStock);
                        }
                        else
                        {
                            baseDatos.controlTransaccion = BaseDatos.EstadoTransaccion.error;
                            MessageBox.Show("No hay stock suficiente de " + nombreHelado, "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        datosDetalle += "," + "NULL";
                        datosDetalle += "," + "NULL";
                    }

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

            public DataTable RecuperarVenta(string tipoDoc, string nroDoc, string nombre)
            {
                DataTable tabla = new DataTable();
                string sql = @"	SELECT nroTicket, 
			                    nroDocEmpleado,
			                    tipoDocEmpleado,
			                    CONVERT(varchar, fecha, 103) as fecha,
			                    nombre,
			                    SUM(Total) as SumTotal
	                            FROM (
		                                SELECT	V.nroTicket,
				                                V.nroDocEmpleado,
				                                V.tipoDocEmpleado,
				                                V.fecha,
				                                E.nombre, 
				                                SUM( D.cantKilos * H.precio) as Total
		                                FROM Ventas V
			                                INNER JOIN Empleados E ON (V.tipoDocEmpleado = E.tipoDoc) AND (V.nroDocEmpleado = E.nroDoc)
			                                INNER JOIN DetalleVentas D ON (V.nroTicket = D.nroTicket)
			                                INNER JOIN Helados H ON (D.idHeladoSimple = H.idHelado)
		                                GROUP BY V.nroTicket, V.nroDocEmpleado, V.tipoDocEmpleado, V.fecha, E.nombre
		                                UNION
		                                SELECT	V.nroTicket, 
				                                V.nroDocEmpleado,
				                                V.tipoDocEmpleado,
				                                V.fecha,
				                                E.nombre, 
				                                SUM(D.cantItems * HE.precio) as Total
		                                FROM Ventas V
			                                INNER JOIN Empleados E ON (V.tipoDocEmpleado = E.tipoDoc) AND (V.nroDocEmpleado = E.nroDoc)
			                                INNER JOIN DetalleVentas D ON (V.nroTicket = D.nroTicket)
			                                INNER JOIN HeladosEspeciales HE ON (D.idHeladoEspecial = HE.idHeladoEspecial)
		                                GROUP BY V.nroTicket, V.nroDocEmpleado, V.tipoDocEmpleado, V.fecha, E.nombre
		                                ) AS Resultado
	                                WHERE ";
                sql += "tipoDocEmpleado =" + tipoDoc + " AND nroDocEmpleado LIKE '" + nroDoc + "'" +
                       " AND nombre LIKE '" + nombre + "'";
                sql += " GROUP BY nroTicket, nroDocEmpleado, tipoDocEmpleado, fecha, nombre";

                tabla = baseDatos.Consulta(sql);
                return tabla;
            }


            public DataTable RecuperarVenta(string fechaDesde, string fechaHasta)
            {
                DataTable tabla = new DataTable();
                string sql = @"	SELECT nroTicket, 
			                    nroDocEmpleado,
			                    tipoDocEmpleado,
			                    CONVERT(varchar, fecha, 103) as fecha,
			                    nombre,
			                    SUM(Total) as SumTotal
	                            FROM (
		                                SELECT	V.nroTicket,
				                                V.nroDocEmpleado,
				                                V.tipoDocEmpleado,
				                                V.fecha,
				                                E.nombre, 
				                                SUM( D.cantKilos * H.precio) as Total
		                                FROM Ventas V
			                                INNER JOIN Empleados E ON (V.tipoDocEmpleado = E.tipoDoc) AND (V.nroDocEmpleado = E.nroDoc)
			                                INNER JOIN DetalleVentas D ON (V.nroTicket = D.nroTicket)
			                                INNER JOIN Helados H ON (D.idHeladoSimple = H.idHelado)
		                                GROUP BY V.nroTicket, V.nroDocEmpleado, V.tipoDocEmpleado, V.fecha, E.nombre
		                                UNION
		                                SELECT	V.nroTicket, 
				                                V.nroDocEmpleado,
				                                V.tipoDocEmpleado,
				                                V.fecha,
				                                E.nombre, 
				                                SUM(D.cantItems * HE.precio) as Total
		                                FROM Ventas V
			                                INNER JOIN Empleados E ON (V.tipoDocEmpleado = E.tipoDoc) AND (V.nroDocEmpleado = E.nroDoc)
			                                INNER JOIN DetalleVentas D ON (V.nroTicket = D.nroTicket)
			                                INNER JOIN HeladosEspeciales HE ON (D.idHeladoEspecial = HE.idHeladoEspecial)
		                                GROUP BY V.nroTicket, V.nroDocEmpleado, V.tipoDocEmpleado, V.fecha, E.nombre
		                                ) AS Resultado
	                                WHERE ";
                sql += " fecha BETWEEN CONVERT(date,'" + fechaDesde +
                       "',103) AND CONVERT(date,'" + fechaHasta + "',103)";
                sql += " GROUP BY nroTicket, nroDocEmpleado, tipoDocEmpleado, fecha, nombre";

                tabla = baseDatos.Consulta(sql);
                return tabla;
            }

            public DataTable RecuperarVenta(string tipoDoc, string nroDoc, string nombre, string fechaDesde,
                string fechaHasta)
            {
                DataTable tabla = new DataTable();
                string sql = @"	SELECT nroTicket, 
			                        nroDocEmpleado,
			                        tipoDocEmpleado,
			                        CONVERT(varchar, fecha, 103) as fecha,
			                        nombre,
			                        SUM(Total) as SumTotal
	                                FROM (
		                                    SELECT	V.nroTicket,
				                                    V.nroDocEmpleado,
				                                    V.tipoDocEmpleado,
				                                    V.fecha,
				                                    E.nombre, 
				                                    SUM( D.cantKilos * H.precio) as Total
		                                    FROM Ventas V
			                                    INNER JOIN Empleados E ON (V.tipoDocEmpleado = E.tipoDoc) AND (V.nroDocEmpleado = E.nroDoc)
			                                    INNER JOIN DetalleVentas D ON (V.nroTicket = D.nroTicket)
			                                    INNER JOIN Helados H ON (D.idHeladoSimple = H.idHelado)
		                                    GROUP BY V.nroTicket, V.nroDocEmpleado, V.tipoDocEmpleado, V.fecha, E.nombre
		                                    UNION
		                                    SELECT	V.nroTicket, 
				                                    V.nroDocEmpleado,
				                                    V.tipoDocEmpleado,
				                                    V.fecha,
				                                    E.nombre, 
				                                    SUM(D.cantItems * HE.precio) as Total
		                                    FROM Ventas V
			                                    INNER JOIN Empleados E ON (V.tipoDocEmpleado = E.tipoDoc) AND (V.nroDocEmpleado = E.nroDoc)
			                                    INNER JOIN DetalleVentas D ON (V.nroTicket = D.nroTicket)
			                                    INNER JOIN HeladosEspeciales HE ON (D.idHeladoEspecial = HE.idHeladoEspecial)
		                                    GROUP BY V.nroTicket, V.nroDocEmpleado, V.tipoDocEmpleado, V.fecha, E.nombre
		                                    ) AS Resultado
	                                    WHERE ";
                sql += "tipoDocEmpleado =" + tipoDoc + " AND nroDocEmpleado LIKE '" + nroDoc + "'" +
                       " AND nombre LIKE '" + nombre + "'";
                sql += " AND fecha BETWEEN CONVERT(date,'" + fechaDesde +
                       "',103) AND CONVERT(date,'" + fechaHasta + "',103)";
                sql += " GROUP BY nroTicket, nroDocEmpleado, tipoDocEmpleado, fecha, nombre";

                tabla = baseDatos.Consulta(sql);
                return tabla;

            }

            public DataTable listadoVentasEmpleado(string nombre)
            {
                string sql = @" SELECT * FROM Ventas V
						    INNER JOIN Empleados E ON (V.nroDocEmpleado = E.nroDoc) AND (V.tipoDocEmpleado = E.tipoDoc) 
							WHERE E.nombre LIKE '" + nombre + "'";
                DataTable tabla = new DataTable();
                tabla = baseDatos.Consulta(sql);
                return tabla;
            }


            public DataTable RecuperarTodasLasVentas()
            {
                DataTable tabla = new DataTable();
                string sql = @"	SELECT nroTicket, 
			                            nroDocEmpleado,
			                            tipoDocEmpleado,
			                            CONVERT(varchar, fecha, 103) as fecha,
			                            nombre,
			                            SUM(Total) as SumTotal
	                                    FROM (
		                                        SELECT	V.nroTicket,
				                                        V.nroDocEmpleado,
				                                        V.tipoDocEmpleado,
				                                        V.fecha,
				                                        E.nombre, 
				                                        SUM( D.cantKilos * H.precio) as Total
		                                        FROM Ventas V
			                                        INNER JOIN Empleados E ON (V.tipoDocEmpleado = E.tipoDoc) AND (V.nroDocEmpleado = E.nroDoc)
			                                        INNER JOIN DetalleVentas D ON (V.nroTicket = D.nroTicket)
			                                        INNER JOIN Helados H ON (D.idHeladoSimple = H.idHelado)
		                                        GROUP BY V.nroTicket, V.nroDocEmpleado, V.tipoDocEmpleado, V.fecha, E.nombre
		                                        UNION
		                                        SELECT	V.nroTicket, 
				                                        V.nroDocEmpleado,
				                                        V.tipoDocEmpleado,
				                                        V.fecha,
				                                        E.nombre, 
				                                        SUM(D.cantItems * HE.precio) as Total
		                                        FROM Ventas V
			                                        INNER JOIN Empleados E ON (V.tipoDocEmpleado = E.tipoDoc) AND (V.nroDocEmpleado = E.nroDoc)
			                                        INNER JOIN DetalleVentas D ON (V.nroTicket = D.nroTicket)
			                                        INNER JOIN HeladosEspeciales HE ON (D.idHeladoEspecial = HE.idHeladoEspecial)
		                                        GROUP BY V.nroTicket, V.nroDocEmpleado, V.tipoDocEmpleado, V.fecha, E.nombre
		                                        ) AS Resultado ";
                sql += " GROUP BY nroTicket, nroDocEmpleado, tipoDocEmpleado, fecha, nombre";

                tabla = baseDatos.Consulta(sql);
                return tabla;
            }

            public DataTable EstadisticaTotalesHeladosPeriodo(DateTime fechaDesde, DateTime fechaHasta)
            {
                string sql = @"SELECT H.nombre as Helado, SUM(DV.cantKilos * H.precio) as 'Total'
                                FROM Ventas V
                                INNER JOIN DetalleVentas DV ON (V.nroTicket = DV.nroTicket)
                                INNER JOIN Helados H ON (DV.idHeladoSimple = H.idHelado)
                                WHERE V.fecha BETWEEN CONVERT(datetime, '" + fechaDesde.Date.ToShortDateString() + "', 103) AND CONVERT(datetime, '" + fechaHasta.Date.ToShortDateString() + "', 103)" +
                                @"GROUP BY H.nombre
                                UNION
                                SELECT HE.nombreProducto as Helado, SUM(DV.cantItems * HE.precio) as 'Total'
                                FROM Ventas V
                                INNER JOIN DetalleVentas DV ON (V.nroTicket = DV.nroTicket)
                                INNER JOIN HeladosEspeciales HE ON (DV.idHeladoEspecial = HE.idHeladoEspecial)
                                WHERE V.fecha BETWEEN CONVERT(datetime, '" + fechaDesde.Date.ToShortDateString() + "', 103) AND CONVERT(datetime, '" + fechaHasta.Date.ToShortDateString() + "', 103)" +
                                "GROUP BY HE.nombreProducto";

                DataTable tabla = new DataTable();
                tabla = baseDatos.Consulta(sql);
                return tabla;
            }


            public DataTable EstadisticaTotalesHelados()
            {
                string sql = @"SELECT H.nombre as Helado, SUM(DV.cantKilos * H.precio) as 'Total'
                                FROM Ventas V
                                INNER JOIN DetalleVentas DV ON (V.nroTicket = DV.nroTicket)
                                INNER JOIN Helados H ON (DV.idHeladoSimple = H.idHelado)
                                GROUP BY H.nombre
                                UNION
                                SELECT HE.nombreProducto as Helado, SUM(DV.cantItems * HE.precio) as 'Total'
                                FROM Ventas V
                                INNER JOIN DetalleVentas DV ON (V.nroTicket = DV.nroTicket)
                                INNER JOIN HeladosEspeciales HE ON (DV.idHeladoEspecial = HE.idHeladoEspecial)
                                 GROUP BY HE.nombreProducto";

                DataTable tabla = new DataTable();
                tabla = baseDatos.Consulta(sql);
                return tabla;
            }



            public DataTable EstadisticaCantidadVentasEmpleados()
            {
                string sql = @"SELECT E.nombre as Nombre, E.apellido as Apellido, COUNT(*) AS Cantidad
                                FROM	Ventas V
                                INNER JOIN Empleados E ON (V.tipoDocEmpleado = E.tipoDoc) AND (E.nroDoc = V.nroDocEmpleado)
                                GROUP BY E.nombre, E.apellido";

                DataTable tabla = new DataTable();
                tabla = baseDatos.Consulta(sql);
                return tabla;
            }
            public DataTable EstadisticaCantidadVentasEmpleadosPeriodo(DateTime fechaDesde, DateTime fechaHasta)
            {
                string sql = @"SELECT E.nombre as Nombre, E.apellido as Apellido, COUNT(*) AS Cantidad
                                FROM	Ventas V
                                INNER JOIN Empleados E ON (V.tipoDocEmpleado = E.tipoDoc) AND (E.nroDoc = V.nroDocEmpleado)
                               WHERE V.fecha BETWEEN CONVERT(datetime, '"+fechaDesde.ToShortDateString()+"', 103) AND CONVERT(datetime, '"+ fechaHasta.ToShortDateString()+"', 103)"+
                                "GROUP BY E.nombre, E.apellido";

            DataTable tabla = new DataTable();
                tabla = baseDatos.Consulta(sql);
                return tabla;
            }

            public DataTable EstadisticaVentasXTurno()
            {
                    string sql = @"select E.idTurno, count(E.nroDoc) as CantidadVentas
		                from Ventas V join Empleados E on V.nroDocEmpleado = E.nroDoc
		                group by E.idTurno";

                DataTable tabla = new DataTable();
                tabla = baseDatos.Consulta(sql);
                return tabla;
            }
        }
    }


