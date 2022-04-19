using Practico.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico.Formularios.Abm.Usuarios;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace Practico.Negocios
{
	class Frutas
	{
		private BaseDatos baseDatos = new BaseDatos();
		public enum Respuesta
		{   validacionCorrecta,
			validacionIncorrecta
		};

		public EstructuraComboBox EstrCombo()
		{
			EstructuraComboBox ec = new EstructuraComboBox();
			ec.Display = "nombre";
			ec.Value = "idFruta";
			ec.Sql = "SELECT * FROM Frutas";
			ec.Tabla = baseDatos.Consulta(ec.Sql);
			return ec;
		}
		public Respuesta ValidarFruta(string nombreFruta)
        {
			string sql = "SELECT * FROM Frutas WHERE nombre ='" + nombreFruta + "'";
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
		

		public DataTable RecuperarFruta(int id)
		{
			string sql = "SELECT * FROM Frutas WHERE idFruta = " + id;
			DataTable tabla = new DataTable();
			tabla = baseDatos.Consulta(sql);
			return tabla;
		}

		public DataTable TodasLasFrutas()
        {
			string sql = "SELECT * FROM Frutas";
			DataTable tabla = new DataTable();
			tabla = baseDatos.Consulta(sql);
			return tabla;
        }

		public DataTable BuscarFruta(string nombreFruta)
        {
			string sql = "SELECT * FROM Frutas WHERE nombre LIKE '%" + nombreFruta.Trim() + "%";
				DataTable tabla = baseDatos.Consulta(sql);
			return tabla;
        }
		
		public Respuesta IngresarFruta(string nombre)
        {
			string sql = "INSERT INTO Frutas VALUES" + "('" + nombre + "')";
			try
			{
				baseDatos.Insertar(sql);
				return Respuesta.validacionCorrecta;

			}
			catch (SqlException)
			{
				return Respuesta.validacionIncorrecta;
			}

		}

		public Respuesta EliminarFruta(int id)
        {
			string sql = "DELETE FROM Frutas WHERE idFruta=" + id;
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

		public Respuesta ModificarFruta(int id, string nombre)
        {
			string sql = "UPDATE Frutas" + "SET nombre = '" + nombre + "' WHERE idFruta =" + id;
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
		
	}
}
