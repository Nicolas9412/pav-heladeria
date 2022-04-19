using Practico.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Practico.Negocios
{
    class HeladosHeladosEspeciales
    {
        private BaseDatos baseDatos = new BaseDatos();


        public enum Respuesta
        {
            validacionCorrecta,
            validacionIncorrecta
        }

        public DataTable todosLosHelados()
        {
            string sql = "SELECT HHS.*," +
                         " H.nombre AS nombreHelado," +
                         " HS.nombreProducto" +
                         " FROM HeladosHeladosEspeciales HHS" +
                         " INNER JOIN HeladosEspeciales HS ON (HHS.idHeladoEspecial = HS.idHeladoEspecial)" +
                         " INNER JOIN Helados H ON (HHS.idHelado = H.idHelado)";

            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public DataTable buscarHelado(string heladoEspecial, string helado)
        {
            string sql = "SELECT HHS.*," +
                       " H.nombre AS nombreHelado," +
                       " HS.nombreProducto" +
                       " FROM HeladosHeladosEspeciales HHS" +
                       " INNER JOIN HeladosEspeciales HS ON (HHS.idHeladoEspecial = HS.idHeladoEspecial)" +
                       " INNER JOIN Helados H ON (HHS.idHelado = H.idHelado)" +
                       " WHERE HHS.idHelado IN " + helado +
                       " AND HHS.idHeladoEspecial IN " + heladoEspecial;

            DataTable tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public Respuesta InsertarHelado(int idHeladoEspecial, int idHelado, int cantBochas)
        {
            string sql = "INSERT INTO HeladosHeladosEspeciales  (idHeladoEspecial,idHelado,cantBochas) VALUES " +
                "(" + idHeladoEspecial + "," + idHelado + ",'" + cantBochas + "')";

            try
            {
                baseDatos.Insertar(sql);
                return Respuesta.validacionCorrecta;

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return Respuesta.validacionIncorrecta;
            }
        }

        public DataTable RecuperarHelado(string heladoEspecial, string helado)
        {
            string sql = "SELECT HHS.*," +
                      "H.nombre AS nombreHelado," +
                      "HS.nombreProducto" +
                      " FROM HeladosHeladosEspeciales HHS" +
                      " INNER JOIN HeladosEspeciales HS ON (HHS.idHeladoEspecial = HS.idHeladoEspecial)" +
                      " INNER JOIN Helados H ON (HHS.idHelado = H.idHelado)" +
                      " WHERE HS.nombreProducto LIKE '" + heladoEspecial + "'" +
                      " AND H.nombre LIKE '" + helado + "'";
            DataTable tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public Respuesta ModificarHelado(int idHeladoEspecial, int idHelado, int cantBochas)
        {
            string sql = "UPDATE HeladosHeladosEspeciales" + " SET cantBochas = " + cantBochas +
                         " WHERE idHeladoEspecial = " + idHeladoEspecial + "AND idHelado = " + idHelado;

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

        public Respuesta EliminarHelado(int idHeladoEspecial, int idHelado)
        {
            string sql = "DELETE FROM HeladosHeladosEspeciales" +
                         " WHERE idHeladoEspecial = " + idHeladoEspecial + "AND idHelado = " + idHelado;
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
