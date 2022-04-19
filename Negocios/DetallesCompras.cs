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
    class DetallesCompras
    {
        public DataTable RecuperarDetalle(string nroComprobante)
        {
            BaseDatos baseDatos = new BaseDatos();

            baseDatos.IniciarTransaccion();

            DataTable tabla = new DataTable();

            string sql = @"SELECT	CONVERT(varchar,C.fecha,103) AS fecha,
                                    P.razonSocial AS razonSocial,
                                    C.tipoDocProveedor AS tipoDocProveedor,
                                    C.nroDocProveedor AS nroDocProveedor,
                                    D.nroItem AS nroItem,
		                            D.idHelado AS idHelado,
		                            H.nombre AS nombre,
		                            D.cantKilos AS cantidad,
		                            PH.precio AS precio,
		                            (D.cantKilos * PH.precio) AS subTotal
                            FROM Compras C 
                            INNER JOIN Proveedores P ON (C.tipoDocProveedor = P.tipoDocumento) AND (C.nroDocProveedor = P.nroDocumento)
                            INNER JOIN DetallesCompras D ON (C.nroComprobante = D.nroComprobante)
                            INNER JOIN ProveedoresHelados PH ON (C.tipoDocProveedor = PH.tipoDocProveedor) AND (C.nroDocProveedor = PH.nroDocProveedor) AND (D.idHelado = PH.idHelado)
                            INNER JOIN Helados H ON (D.idHelado = H.idHelado)
                            WHERE D.nroComprobante =" + nroComprobante;

            tabla = baseDatos.Consulta(sql);
            return tabla;
        }


        public void ModificarDetalle(string nroComprobante, string tipoDocProveedor, string nroDocProveedor, Grid01 detalles)
        {
            BaseDatos baseDatos = new BaseDatos();
            DataTable tabla = new DataTable();
            TratamientosEspeciales tratamientos = new TratamientosEspeciales();

            string actualizarStock = "";

            string insertDetalle =
                @"INSERT INTO DetallesCompras (nroComprobante, tipoDocProveedor, nroDocProveedor, idHelado, cantKilos) VALUES (";

            string deleteDetalle = @"DELETE FROM DetallesCompras WHERE nroComprobante=" + nroComprobante + " AND nroItem=";


            for (int i = 0; i < detalles.Rows.Count; i++)
            {
                string nroItem = detalles.Rows[i].Cells[0].Value.ToString();
                string idHelado = detalles.Rows[i].Cells[1].Value.ToString();
                string nombreHelado = detalles.Rows[i].Cells[2].Value.ToString();
                string cantKilos = detalles.Rows[i].Cells[4].Value.ToString();
                string estado = detalles.Rows[i].Cells[6].Value.ToString();


                if (estado == "nuevo")
                {
                    string datosDetalle = nroComprobante;
                    datosDetalle += "," + tipoDocProveedor;
                    datosDetalle += "," + nroDocProveedor;
                    datosDetalle += "," + idHelado;
                    datosDetalle += "," + cantKilos;

                    actualizarStock = "UPDATE Helados " +
                                      " SET cantidadStock += CAST(" + cantKilos.Replace(",00", ".00") + " AS INT)" +
                                      " WHERE idHelado =" + idHelado;
                    baseDatos.Actualizar(actualizarStock);

                    datosDetalle += ")";
                    string insertFinal = insertDetalle + datosDetalle;
                    baseDatos.Insertar(insertFinal);
                }

                if (estado == "eliminado")
                {
                    string datosDelete = nroItem;

                    actualizarStock = "UPDATE Helados " +
                                      " SET cantidadStock -= CAST(" + cantKilos.Replace(",00",".00") + " AS INT)" +
                                      " WHERE idHelado =" + idHelado;
                    baseDatos.Actualizar(actualizarStock);


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
