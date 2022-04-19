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
    class Usuarios
    {
        private BaseDatos baseDatos = new BaseDatos(); // creacion de la base de datos

        public enum Respuesta
        {
            validacionCorrecta,
            validacionIncorrecta
        };

        public EstructuraComboBox EstrCombo()
        {
            EstructuraComboBox ec = new EstructuraComboBox();
            ec.Display = "nombreUsuario";
            ec.Value = "idUsuario";
            ec.Sql = "SELECT * FROM Usuarios";
            ec.Tabla = baseDatos.Consulta(ec.Sql);
            return ec;
        }

        public Respuesta ValidarUsuario(string usuario, string password) // valida si el usuario existe
        {
            string sql = "SELECT * FROM Usuarios WHERE nombreUsuario = '" + usuario + "' AND contrasenia= '" +
                         password + "'";
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

        public int RecuperarIdUsuario(string usuario, string password)
        {
            string sql = "SELECT * FROM Usuarios WHERE nombreUsuario = '" + usuario + "' AND contrasenia= '" +
                         password + "'";
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);

            if (tabla.Rows.Count == 1)
            {
                return int.Parse(tabla.Rows[0]["idUsuario"].ToString()); // retorna idUsuario
            }
            else
            {
                return 0;
            }
        }

        public DataTable TodosLosUsuarios()
        {
            string sql = "SELECT * FROM Usuarios ";
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }


        public DataTable BuscarUsuario(string nombre)
        {
            string sql = "SELECT * FROM Usuarios WHERE nombreUsuario LIKE '%" + nombre.Trim() + "%'";
            DataTable tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        // NO LO DIO EN CLASES
        
        public Respuesta IngresarUsuario(string nombre, string contraseña)
        {
            string sql = "INSERT INTO Usuarios VALUES "+"('"+nombre+"','"+contraseña+"')";

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

        public Respuesta EliminarUsuario(int id)
        {
            string sql = "DELETE FROM Usuarios WHERE idUsuario =" + id;

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

        public DataTable RecuperarUsuario(int id)
        {
            string sql = "SELECT * FROM Usuarios WHERE idUsuario = " + id;
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }


        public Respuesta ModificarUsuario(int id, string nombre, string contraseña)
        {
            string sql = "UPDATE Usuarios" + " SET nombreUsuario = '" + nombre +
                         "'," + "contrasenia ='" + contraseña + "' " +
                         "WHERE idUsuario = " + id;

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
