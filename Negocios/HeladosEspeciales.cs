using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Practico.Clases;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Practico.Negocios
{
    class HeladosEspeciales
    {

        BaseDatos baseDatos = new BaseDatos();

        public enum Respuesta
        {
            validacionCorrecta,
            validacionIncorrecta
        }

        public EstructuraComboBox EstrCombo()
        {
            EstructuraComboBox ec = new EstructuraComboBox();
            ec.Display = "nombreProducto";
            ec.Value = "idHeladoEspecial";
            ec.Sql = "SELECT * FROM HeladosEspeciales";
            ec.Tabla = baseDatos.Consulta(ec.Sql);
            return ec;
        }

        public DataTable TodosLosHeladosEspeciales()
        {
            string sql = "SELECT * FROM HeladosEspeciales P";
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }


        public DataTable RecuperarHeladosEspeciales(string idHeladoEspecial)
        {
            string sql = "SELECT P.* FROM HeladosEspeciales P " +
                         " WHERE idHeladoEspecial LIKE '" + idHeladoEspecial +"'";
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public DataTable BuscarHeladosEspeciales(string nombreProducto)
        {
            string sql = "SELECT * FROM HeladosEspeciales P WHERE nombreProducto LIKE '%" + nombreProducto.Trim() + "%'";
            DataTable tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public Respuesta Insertar(Control.ControlCollection controles)
        {
            try
            {
                baseDatos.InsertarAutomatizado("HeladosEspeciales", controles);
                return Respuesta.validacionCorrecta;

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return Respuesta.validacionIncorrecta;
            }

        }


        //public Respuesta Modificar(int idHeladoEspecial, string idHelado, Control.ControlCollection controles)
        public Respuesta Modificar(string idHeladoEspecial, Control.ControlCollection controles)
        {
            try
            {
                baseDatos.ModificarAutomatizado("HeladosEspeciales", " idHeladoEspecial  =" + idHeladoEspecial, controles);
                //baseDatos.ModificarAutomatizado("HeladosEspeciales", " idHelado  =" + idHelado + " AND idHeladoEspecial LIKE '" + idHeladoEspecial + "'", controles);
                return Respuesta.validacionCorrecta;

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return Respuesta.validacionIncorrecta;
            }

        }


        public Respuesta Eliminar(int idHeladoEspecial)
        {
            string sql = "DELETE FROM HeladosEspeciales WHERE idHeladoEspecial LIKE '" + idHeladoEspecial +"'";

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

        public DataTable ListadoHeladosEspecialesPrecio(string precio)
        {
            string sql = @"SELECT	H.idHeladoEspecial,
		                            H.nombreProducto,
		                            H.precio,
                                    H.cantidadStock
                            FROM HeladosEspeciales H
                            WHERE H.precio > " + precio;
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public DataTable EstadisticasStockHeladosEspeciales()
        {
            string sql = "SELECT nombreProducto, cantidadStock FROM HeladosEspeciales";

            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }
    }
}
