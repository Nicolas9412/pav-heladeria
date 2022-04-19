using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Practico.Clases;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Practico.Negocios
{
    class ProveedoresHelados
    {
        BaseDatos baseDatos = new BaseDatos();

        public enum Respuesta
        {
            validacionCorrecta,
            validacionIncorrecta
        }

        public DataTable TodosLosProveedoresHelados()
        {
            string sql = "SELECT * FROM ProveedoresHelados PH JOIN TiposDocumento TD ON PH.tipoDocProveedor = TD.tipoDocumento " +
                                                             "JOIN Proveedores P ON(PH.tipoDocProveedor= P.tipoDocumento AND PH.nroDocProveedor=P.nroDocumento) " +
                                                             "JOIN Helados H ON PH.idHelado = H.idHelado";
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public DataTable RecuperarProoveedorHelado(string tipoDocumento, string nroDocumento, string idHelado)
        {
            string sql = "SELECT PH.* FROM ProveedoresHelados PH INNER JOIN TiposDocumento TD ON (PH.tipoDocProveedor = TD.tipoDocumento) " +
                                                                "INNER JOIN helados H ON (PH.idHelado=H.idHelado) " +
                         " WHERE descripcion LIKE '" + tipoDocumento + "' AND nroDocProveedor LIKE '" + nroDocumento + "' AND nombre = '" + idHelado + "'";
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public int RecuperarIdHelado(string idHelado)
        {
            string sql = "SELECT H.idHelado FROM ProveedoresHelados PH JOIN Helados H ON PH.idHelado=H.idHelado" +
                                                                     " WHERE nombre = '" + idHelado + "'";
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            int idHeladoRecuperado = Int32.Parse(tabla.Rows[0]["idHelado"].ToString());
            return idHeladoRecuperado;
        }

        public DataTable BuscarProveedorHelado(string razonSocial,string nombre)
        {
            string sql = "SELECT * FROM ProveedoresHelados PH JOIN TiposDocumento TD ON PH.tipoDocProveedor = TD.tipoDocumento " +
                                                             "JOIN Proveedores P ON(PH.tipoDocProveedor= P.tipoDocumento AND PH.nroDocProveedor=P.nroDocumento) " +
                                                             "JOIN Helados H ON PH.idHelado = H.idHelado " +
                                                             "WHERE razonSocial LIKE '%" + razonSocial.Trim() + "%' AND nombre LIKE '%" + nombre.Trim() + "%'";
            DataTable tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public Respuesta Insertar(Control.ControlCollection controles)
        {
            try
            {
                baseDatos.InsertarAutomatizado("ProveedoresHelados", controles);
                return Respuesta.validacionCorrecta;

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return Respuesta.validacionIncorrecta;
            }

        }

        /*  
        public Respuesta Modificar(int tipoDocumento,string nroDocumento,int idHelado,int precio, Control.ControlCollection controles)
         {
             try
             {
                 baseDatos.ModificarAutomatizado("ProveedoresHelados", " tipoDocumento  =" + tipoDocumento + " AND nroDocumento LIKE '" + nroDocumento + "'"
                                                 + " AND idHelado = '" + idHelado + "'" + " AND precio =  '" + precio + "'", controles);
                 return Respuesta.validacionCorrecta;

             }
             catch (SqlException exception)
             {
                 MessageBox.Show(exception.ToString());
                 return Respuesta.validacionIncorrecta;
             }

         }
         */
        public Respuesta ModificarProveedorHelado(int tipoDoc, int nroDoc, int idHelado, int precio)
        {
            string sql = "UPDATE ProveedoresHelados" + " SET precio = " + precio +
                         " WHERE tipoDocProveedor = " + tipoDoc + "AND nroDocProveedor = " + nroDoc +
                                                                  "AND idHelado = " + idHelado;

            try
            {
                baseDatos.Actualizar(sql);
                return Respuesta.validacionCorrecta;

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return Respuesta.validacionIncorrecta;
            }
        }

        public Respuesta Eliminar(int tipoDocumento, string nroDocumento, int idHelado)
        {
            string sql = "DELETE FROM ProveedoresHelados WHERE tipoDocProveedor = " + tipoDocumento + " AND nroDocProveedor LIKE '" + nroDocumento + "' AND idHelado = " + idHelado;

            try
            {
                baseDatos.Eliminar(sql);
                return Respuesta.validacionCorrecta;

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return Respuesta.validacionIncorrecta;
            }

        }
    }
}
