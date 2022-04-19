using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico.Clases;

namespace Practico.Negocios
{
    class DetalleVentas
    {

        public DataTable RecuperarDetalle(string nroTicket)
        {
            BaseDatos baseDatos = new BaseDatos();

            baseDatos.IniciarTransaccion();

            DataTable tabla = new DataTable();

            string sql = @"SELECT	D.nroItem AS nroItem,
		                            H.idHelado AS idHelado,
		                            H.nombre AS nombre,
		                            D.cantKilos AS cantidad,
		                            H.precio AS precio,
		                            ISNULL(D.idHeladoEspecial,0) AS especial
                            FROM Ventas V 
                            INNER JOIN Empleados E ON (V.nroDocEmpleado = E.nroDoc) AND (V.tipoDocEmpleado = E.tipoDoc)
                            INNER JOIN DetalleVentas D ON (V.nroTicket = D.nroTicket)
                            INNER JOIN Helados H ON (D.idHeladoSimple = H.idHelado)
                            WHERE D.nroTicket =" + nroTicket +
                         @" UNION
                            SELECT	D.nroItem AS nroItem,
		                            HE.idHeladoEspecial AS idHelado,
		                            HE.nombreProducto AS nombre,
		                            D.cantItems AS cantidad,
		                            HE.precio AS precio,
		                            ISNULL(D.idHeladoSimple,1) AS especial
                            FROM Ventas V 
                            INNER JOIN Empleados E ON (V.nroDocEmpleado = E.nroDoc) AND (V.tipoDocEmpleado = E.tipoDoc)
                            INNER JOIN DetalleVentas D ON (V.nroTicket = D.nroTicket)
                            INNER JOIN HeladosEspeciales HE ON (D.idHeladoEspecial = HE.idHeladoEspecial)
                            WHERE D.nroTicket = " + nroTicket;

            tabla = baseDatos.Consulta(sql);
            return tabla;
        }


        public void ModificarDetalle(string nroTicket, Grid01 detalles)
        {
            BaseDatos baseDatos = new BaseDatos();
            DataTable tabla = new DataTable();
            TratamientosEspeciales tratamientos = new TratamientosEspeciales();

            string actualizarStock = "";

            string insertDetalle =
                @"INSERT INTO DetalleVentas (nroTicket, idHeladoSimple, cantKilos, idHeladoEspecial, cantItems) VALUES (";

            string deleteDetalle = @"DELETE FROM DetalleVentas WHERE nroTicket=" + nroTicket + " AND nroItem=";


            for (int i = 0; i < detalles.Rows.Count; i++)
            {
                string idHeladoSimple = detalles.Rows[i].Cells[1].Value.ToString();
                string cantKilos = detalles.Rows[i].Cells[4].Value.ToString();
                string idHeladoEspecial = detalles.Rows[i].Cells[1].Value.ToString();
                string cantItems = detalles.Rows[i].Cells[4].Value.ToString();
                string esEspecial = detalles.Rows[i].Cells[6].Value.ToString();
                string nombreHelado = detalles.Rows[i].Cells[2].Value.ToString();
                string estado = detalles.Rows[i].Cells[7].Value.ToString();
                string nroItem = detalles.Rows[i].Cells[0].Value.ToString();



                if (estado == "nuevo")
                {
                    string datosDetalle = nroTicket;

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
                            MessageBox.Show("No hay stock suficiente de " + nombreHelado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            MessageBox.Show("No hay stock suficiente de " + nombreHelado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                

                if (estado == "eliminado")
                {
                    string datosDelete = nroItem;

                    if (esEspecial == "false")
                    {
                        actualizarStock = "UPDATE Helados " +
                                          " SET cantidadStock += " + cantKilos +
                                          " WHERE idHelado =" + idHeladoSimple;
                        baseDatos.Actualizar(actualizarStock);
                    }
                    else
                    {
                        actualizarStock = "UPDATE HeladosEspeciales " +
                                          " SET cantidadStock += " + cantItems +
                                          " WHERE idHeladoEspecial =" + idHeladoEspecial;
                        baseDatos.Actualizar(actualizarStock);
                    }

                    string deleteFinal = deleteDetalle + datosDelete;
                    baseDatos.Eliminar(deleteFinal);
                }

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
    }
}
