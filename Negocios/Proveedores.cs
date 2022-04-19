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
    class Proveedores
    {

        BaseDatos baseDatos = new BaseDatos();

        public EstructuraComboBox EstrCombo()
        {
            EstructuraComboBox ec = new EstructuraComboBox();
            ec.Display = "nroDocumento";
            ec.Value = "nroDocumento";
            ec.Sql = "SELECT * FROM Proveedores";
            ec.Tabla = baseDatos.Consulta(ec.Sql);
            return ec;
        }

        public enum Respuesta
        {
            validacionCorrecta,
            validacionIncorrecta
        }

        public DataTable TodosLosProveedores()
        {
            string sql = "SELECT * FROM Proveedores P JOIN TiposDocumento TD ON P.tipoDocumento=TD.tipoDocumento";
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public DataTable RecuperarProoveedor(string tipoDocumento, string nroDocumento)
        {
            string sql = "SELECT P.* FROM Proveedores P INNER JOIN TiposDocumento TD ON (P.tipoDocumento = TD.tipoDocumento)" +
                         " WHERE descripcion LIKE '" + tipoDocumento + "' AND nroDocumento LIKE '" + nroDocumento +"'";
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public DataTable BuscarProveedor(string razonSocial)
        {
            string sql = "SELECT * FROM Proveedores P JOIN TiposDocumento TD ON P.tipoDocumento=TD.tipoDocumento WHERE razonSocial LIKE '%" + razonSocial.Trim() + "%'";
            DataTable tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public Respuesta Insertar(Control.ControlCollection controles)
        {
            try
            {
                baseDatos.InsertarAutomatizado("Proveedores", controles);
                return Respuesta.validacionCorrecta;

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return Respuesta.validacionIncorrecta;
            }

        }

        public Respuesta Modificar(int tipoDocumento, string nroDocumento, Control.ControlCollection controles)
        {
            try
            {
                baseDatos.ModificarAutomatizado("Proveedores", " tipoDocumento  =" + tipoDocumento + " AND nroDocumento LIKE '" + nroDocumento + "'", controles);
                return Respuesta.validacionCorrecta;

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return Respuesta.validacionIncorrecta;
            }

        }

        public Respuesta Eliminar(int tipoDocumento, string nroDocumento)
        {
            string sql = "DELETE FROM Proveedores WHERE tipoDocumento LIKE '" + tipoDocumento + "' AND nroDocumento LIKE '" + nroDocumento +"'";

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

        public DataTable ListadoProveedoresBarrio(String barrio)
        {
            string sql = @"SELECT	TD.descripcion AS tipoDocumento,
		                            P.nroDocumento,
		                            P.razonSocial,
		                            P.mail,
		                            P.telCelular,
		                            P.telFijo,
                                    P.calle,
                                    P.nroCalle,
		                            B.nombre AS idBarrio		                           
                            FROM Proveedores P
                             INNER JOIN TiposDocumento TD ON (P.tipoDocumento = TD.tipoDocumento)
                             INNER JOIN Barrios B ON (P.idBarrio = B.idBarrio)
                            WHERE P.idBarrio =" + barrio;

            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public DataTable EstadisticaProveedoresXLocalidad()
        {
            string sql = @"SELECT l.nombre as Localidad, count(l.nombre) as Cantidad from Proveedores p JOIN Barrios b on p.idBarrio = b.idBarrio
                            JOIN Localidades l on l.idLocalidad = b.idLocalidad
                            group by l.nombre ";

            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }


    }
}
