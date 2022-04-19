using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico.Clases;

namespace Practico.Negocios
{
    class TelefonosEmpleados
    {
        private BaseDatos baseDatos = new BaseDatos(); // creacion de la base de datos

        public enum Respuesta
        {
            validacionCorrecta,
            validacionIncorrecta
        }

        public DataTable TodosLosTelefonos()
        {
            string sql = "SELECT T.*," +
                         "E.nombre," +
                         "TD.descripcion" +
                         " FROM TelefonosEmpleados T " +
                         "  INNER JOIN Empleados E ON (T.tipoDocEmpleado = E.tipoDoc) AND (T.nroDocEmpleado = E.nroDoc)" +
                         "  INNER JOIN TiposDocumento TD ON (T.tipoDocEmpleado = TD.tipoDocumento)";

            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public DataTable BuscarTelefono(string nombre, string tipoDoc, string nroDoc)
        {
            string sql = "SELECT T.*," +
                         "E.nombre," +
                         "TD.descripcion" +
                         " FROM TelefonosEmpleados T " +
                         "  INNER JOIN Empleados E ON (T.tipoDocEmpleado = E.tipoDoc) AND (T.nroDocEmpleado = E.nroDoc)" +
                         "  INNER JOIN TiposDocumento TD ON (T.tipoDocEmpleado = TD.tipoDocumento)" +
                         " WHERE E.nombre LIKE '%" + nombre.Trim() + "%'" +
                         "  AND E.tipoDoc IN " + tipoDoc +
                         "  AND E.nroDoc LIKE '%" + nroDoc.Trim() + "%'";

            DataTable tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public Respuesta InsertarTelefono(long nroTelefono, int tipoDoc, string nroDoc)
        {
            string sql = "INSERT INTO TelefonosEmpleados (nroTelefono, tipoDocEmpleado, nroDocEmpleado ) VALUES " +
                         "(" + nroTelefono + "," + tipoDoc + ",'" + nroDoc + "')";
            try
            {
                baseDatos.Insertar(sql);
                return TelefonosEmpleados.Respuesta.validacionCorrecta;

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return TelefonosEmpleados.Respuesta.validacionIncorrecta;
            }
        }

        public Respuesta ModificarTelefono(long nroTelefono, int tipoDoc, string nroDoc)
        {
            string sql = "UPDATE TelefonosEmpleados" + " SET tipoDocEmpleado = " + tipoDoc +
                         " ,nroDocEmpleado ='" + nroDoc + "'" +
                         " WHERE nroTelefono = " + nroTelefono;

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

        public DataTable RecuperarTelefono(long nroTelefono)
        {
            string sql = "SELECT * FROM TelefonosEmpleados T " + 
                         "INNER JOIN Empleados E ON (T.tipoDocEmpleado = E.tipoDoc) AND (T.nroDocEmpleado = E.nroDoc)"+
                         " WHERE T.nroTelefono = " + nroTelefono;

            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }
        public Respuesta EliminarTelefono(long nroTelefono)
        {
            string sql = "DELETE FROM TelefonosEmpleados WHERE nroTelefono =" + nroTelefono;

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
