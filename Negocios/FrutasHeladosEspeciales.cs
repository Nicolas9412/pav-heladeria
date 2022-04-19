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
    class FrutasHeladosEspeciales
    {
        private BaseDatos baseDatos = new BaseDatos(); // creacion de la base de datos

        public enum Respuesta
        {
            validacionCorrecta,
            validacionIncorrecta
        }

        public DataTable TodosLasFrutas()
        {
            string sql = "SELECT F.*," +
                         " FR.nombre AS nombreFruta," +
                         " H.nombreProducto" +
                         " FROM FrutasHeladosEspeciales F " +
                         "  INNER JOIN HeladosEspeciales H ON (F.idHeladoEspecial = H.idHeladoEspecial)" +
                         "  INNER JOIN Frutas FR ON (F.idFruta = FR.idFruta)";

            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public DataTable BuscarFruta(string heladoEspecial, string fruta)
        {
            string sql = "SELECT F.*," +
                         " FR.nombre AS nombreFruta," +
                         " H.nombreProducto" +
                         " FROM FrutasHeladosEspeciales F " +
                         "  INNER JOIN HeladosEspeciales H ON (F.idHeladoEspecial = H.idHeladoEspecial)" +
                         "  INNER JOIN Frutas FR ON (F.idFruta = FR.idFruta)" +
                         " WHERE F.idHeladoEspecial IN " + heladoEspecial +
                         "  AND F.idFruta IN " + fruta;

            DataTable tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public Respuesta InsertarFruta(int idHeladoEspecial, int idFruta, float cantGramos)
        {
            string sql = "INSERT INTO FrutasHeladosEspeciales (idHeladoEspecial, idFruta, cantGramos ) VALUES " +
                         "(" + idHeladoEspecial + "," + idFruta + ",'" + cantGramos + "')";
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

        public DataTable RecuperarFruta(string heladoladoEspecial, string fruta)
        {
            string sql = "SELECT F.*," +
                         " FR.nombre AS nombreFruta," +
                         " H.nombreProducto" +
                         " FROM FrutasHeladosEspeciales F " +
                         "  INNER JOIN HeladosEspeciales H ON (F.idHeladoEspecial = H.idHeladoEspecial)" +
                         "  INNER JOIN Frutas FR ON (F.idFruta = FR.idFruta)" +
                         " WHERE H.nombreProducto LIKE '" + heladoladoEspecial + "'" +
                         "  AND FR.nombre LIKE '" + fruta + "'";
            DataTable tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public Respuesta ModificarFruta(int idHeladoEspecial, int idFruta, float cantidad)
        {
            string sql = "UPDATE FrutasHeladosEspeciales" + " SET cantGramos = " + cantidad +
                         " WHERE idHeladoEspecial = " + idHeladoEspecial + " AND idFruta=" + idFruta;

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

        public Respuesta EliminarFruta(int idHeladoEspecial, int idFruta)
        {
            string sql = "DELETE FROM FrutasHeladosEspeciales" +
                         " WHERE idHeladoEspecial = " + idHeladoEspecial + " AND idFruta=" + idFruta;

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
