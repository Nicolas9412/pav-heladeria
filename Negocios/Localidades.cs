using Practico.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico.Formularios.Abm.Usuarios;

namespace Practico.Negocios
{
    class Localidades
    {
        private BaseDatos baseDatos = new BaseDatos();
        public enum Respuesta
        {
            validacionCorrecta,
            validacionIncorrecta
        };

		public EstructuraComboBox EstrCombo()
		{
			EstructuraComboBox ec = new EstructuraComboBox();
			ec.Display = "nombre";
			ec.Value = "idLocalidad";
			ec.Sql = "SELECT * FROM Localidades";
			ec.Tabla = baseDatos.Consulta(ec.Sql);
			return ec;
		}


		public Respuesta ValidarLocalidad(string nombreLocalidad)
		{
			string sql = "SELECT * FROM Localidades WHERE nombre ='" + nombreLocalidad + "'";
			DataTable tabla = new DataTable();
			tabla = baseDatos.Consulta(sql);

			if (tabla.Rows.Count == 1)
			{
				return Respuesta.validacionCorrecta;
			}
			else
			{
				return Respuesta.validacionIncorrecta;
			}
		}

		public DataTable TodasLasLocalidades()
		{
			string sql = "SELECT * FROM Localidades";
			DataTable tabla = new DataTable();
			tabla = baseDatos.Consulta(sql);
			return tabla;
		}

		public DataTable BuscarLocalidad(string nombreLocalidad)
		{
			string sql = "SELECT * FROM Localidades WHERE nombre LIKE '%" + nombreLocalidad.Trim() + "%'";
			DataTable tabla = baseDatos.Consulta(sql);
			return tabla;
		}

		public Respuesta IngresarLocalidad(string nombre)
		{
			string sql = "INSERT INTO Localidades VALUES " + "('" + nombre + "')";


            try
            {
                baseDatos.Insertar(sql);
                return Localidades.Respuesta.validacionCorrecta;

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return Localidades.Respuesta.validacionIncorrecta;
            }
		}

		public Respuesta EliminarLocalidad(int id)
		{
			string sql = "DELETE FROM Localidades WHERE idLocalidad =" + id;
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

		public Respuesta ModificarLocalidad(int id, string nombre)
		{
			string sql = "UPDATE Localidades" + " SET nombre = '" + nombre + "' " +
						 "WHERE idLocalidad = " + id;
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

		public DataTable RecuperarLocalidad(int id)
		{
			string sql = "SELECT * FROM Localidades WHERE idLocalidad = " + id;
			DataTable tabla = new DataTable();
			tabla = baseDatos.Consulta(sql);
			return tabla;
		}
	}
}
