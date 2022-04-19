using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico.Clases;

namespace Practico.Negocios
{
    class Helados
    {
        private BaseDatos baseDatos = new BaseDatos(); // creacion de la base de datos

        public EstructuraComboBox EstrCombo()
        {
            EstructuraComboBox ec = new EstructuraComboBox();
            ec.Display = "nombre";
            ec.Value = "idHelado";
            ec.Sql = "SELECT * FROM Helados";
            ec.Tabla = baseDatos.Consulta(ec.Sql);
            return ec;
        }

        public enum Respuesta
        {
            validacionCorrecta,
            validacionIncorrecta
        }

        public DataTable TodosLosHelados()
        {
            string sql = "SELECT * FROM Helados";
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public DataTable BuscarHelado(string nombre)
        {
            string sql = "SELECT * FROM Helados WHERE nombre LIKE '%" + nombre.Trim() + "%'";
            DataTable tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public Respuesta InsertarHelado(string nombre, float precio, int cantidad)
        {
            string sql = "INSERT INTO Helados VALUES " + "('" + nombre + "'," + precio + "," + cantidad +")";
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
        public Respuesta EliminarHelado(int id)
        {
            string sql = "DELETE FROM Helados WHERE idHelado =" + id;

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

        public Respuesta ModificarHelado(int id, string nombre, float precio, int cantidad)
        {
            string sql = "UPDATE Helados" + " SET nombre = '" + nombre +
                         "'," + "precio =" + precio + ", cantidadStock = " + cantidad +
                        "WHERE idHelado = " + id;

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

        public DataTable RecuperarHelado(int id)
        {
            string sql = "SELECT * FROM Helados WHERE idHelado = " + id;
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }


        public DataTable ListadoHeladosProveedor(String razonSocial)
        {
            string sql = @"SELECT	H.idHelado,
		                            H.nombre,
		                            H.precio,
                                    H.cantidadStock,
		                            P.razonSocial
                            FROM Helados H
	                            INNER JOIN ProveedoresHelados HP ON (H.idHelado = HP.idHelado)
	                            INNER JOIN Proveedores P ON (P.nroDocumento = HP.nroDocProveedor)
				                            AND (P.tipoDocumento = HP.tipoDocProveedor)
                            WHERE P.razonSocial LIKE '"+razonSocial+"'";
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public DataTable ListadoHeladosPrecio(string Precio)
        {
            string sql = @"SELECT	idHelado, nombre, precio
                           FROM Helados
                           WHERE precio <= " +Precio;
                           

            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public DataTable EstadisticasPreciosHelados()
        {
            string sql = "SELECT nombre, precio FROM Helados";

            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }
    }
}
