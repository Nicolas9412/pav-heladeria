using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Practico.Clases;
using System.Data;
using System.Net.Http.Headers;

namespace Practico.Negocios
{
    class Turnos
    {
        private BaseDatos baseDatos = new BaseDatos();

        public enum Respuesta
        {
            validacionCorrecta,
            validacionIncorrecta
        }

        public EstructuraComboBox EstrCombo()
        {
            EstructuraComboBox ec = new EstructuraComboBox();
            ec.Display = "nombre";
            ec.Value = "idTurno";
            ec.Sql = "SELECT * FROM Turnos";
            ec.Tabla = baseDatos.Consulta(ec.Sql);
            return ec;
        }

        public DataTable TodosLosTurnos()
        {
            string sql = "SELECT T.*, CONVERT(time,T.horaInicio,108) as horaInicioT" +
                         ", CONVERT(time,T.horaFin,108) as horaFinT FROM Turnos T";
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public DataTable BuscarTurno(string nombre)
        {
            string sql = "SELECT T.*, CONVERT(time,T.horaInicio,108) as horaInicioT" +
                         ", CONVERT(time,T.horaFin,108) as horaFinT FROM Turnos T"+
                        " WHERE T.nombre LIKE '%" + nombre + "%'";
            DataTable tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public DataTable RecuperarTurno(int id)
        {
            string sql = "SELECT T.*, J.nombre AS nombreJefe FROM Turnos T " +
                         "LEFT JOIN Empleados J ON (T.nroDocSupervisor = J.nroDoc) AND (T.tipoDocSupervisor = J.TipoDoc)" +
                         "WHERE T.idTurno = " + id;
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public Respuesta EliminarTurno(int id)
        {
            string sql = "DELETE FROM Turnos WHERE idTurno = " + id;
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

        public Respuesta InsertarTurno( string nombre, string horaInicio, string horaFin
                                       ,string nroDocSupervisor, int tipoDocSupervisor)
        {
            string sql = "INSERT INTO Turnos(nombre,horaInicio,horaFin,nroDocSupervisor,tipoDocSupervisor) " +
                         "VALUES ('" + nombre + "', convert(time,'" + horaInicio + "',108), convert(Time,'" + horaFin + "',108), '" +
                         nroDocSupervisor + "'," + tipoDocSupervisor + ")";
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

        public Respuesta ModificarTurno(int idTurno, string nombre, string horaInicio, string horaFin
                                       , string nroDocSupervisor, int tipoDocSupervisor)
        {
            string sql = "UPDATE Turnos " +
                         "SET nombre = '" + nombre + "'," +
                         "horaInicio = convert(time,'" + horaInicio + "',108), " +
                         "horaFin = convert(time,'" + horaFin + "',108), " +
                         "nroDocSupervisor = '" + nroDocSupervisor + "', " +
                         "tipoDocSupervisor = " + tipoDocSupervisor +
                         " WHERE idTurno = " + idTurno;
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
