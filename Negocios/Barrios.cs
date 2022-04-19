using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico.Clases;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Practico.Negocios
{
    class Barrios
    {
        private BaseDatos baseDatos = new BaseDatos();

        public EstructuraComboBox EstrCombo()
        {
            EstructuraComboBox ec = new EstructuraComboBox();
            ec.Display = "nombre";
            ec.Value = "idBarrio";
            ec.Sql = "SELECT * FROM Barrios";
            ec.Tabla = baseDatos.Consulta(ec.Sql);
            return ec;
        }

        public enum Respuesta
        {
            validacionCorrecta,
            validacionIncorrecta,
        }

        public DataTable TodosLosBarrios()
        {
            string sql = "SELECT * FROM Barrios";
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }
        
        public DataTable BuscarBarrio(string nombre, string localidad)
        {
            string sql = "SELECT * FROM Barrios WHERE nombre LIKE '%" + nombre.Trim() + "%'" +
                                                 "AND idLocalidad IN" + localidad;
            DataTable tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public Respuesta InsertarBarrio( string nombre,int idLocalidad)
        {
            string sql = "INSERT INTO Barrios(nombre, idLocalidad) VALUES " +
                "('"+ nombre.Trim() + "'," + idLocalidad + ")";

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

        public DataTable RecuperarBarrio(int id)
        {
            string sql = "SELECT * FROM Barrios WHERE idBarrio =" + id ;
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public Respuesta ModificarBarrio(int idBarrio, string nombre, int idLocalidad)
        {
            string sql = "UPDATE Barrios" + " SET nombre = '" + nombre + "',idLocalidad = '" + idLocalidad + "'"
                         + " WHERE idBarrio = " + idBarrio;

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

        public Respuesta EliminarBarrio(int id)
        {
            string sql = "DELETE FROM Barrios WHERE idBarrio = " + id;
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

        public DataTable EstadisticaBarrioXLocalidad()
        {
            string sql = @"SELECT l.nombre as Localidad, count(l.nombre) as Cantidad 
                            FROM Barrios b JOIN Localidades l on b.idLocalidad = l.idLocalidad
                            GROUP BY l.nombre";

            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }
    }
}
