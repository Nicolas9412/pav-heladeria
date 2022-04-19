using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;  //Conector estandar cliente de SQL
using System.Data;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Practico.Clases
{
    class BaseDatos //nueva
    {
        private SqlConnection conexion = new SqlConnection();   // armar conexion
        private SqlCommand comando = new SqlCommand();    // transporte de la consulta
        SqlTransaction transaccion;

        public enum EstadoAccion { correcto, error };
        public enum TipoConexion { simple, transaccional };
        public enum EstadoTransaccion { correcta, error };

        public TipoConexion controlConexion { get; set; } = TipoConexion.simple;
        public EstadoTransaccion controlTransaccion { get; set; } = EstadoTransaccion.correcta;

        //string cadenaConexion = "Data Source=DESKTOP-6V98254\\SQLEXPRESS;Initial Catalog=HeladeriaPAV;Integrated Security=True"; // LUIS
        string cadenaConexion = "Data Source = DESKTOP-DT487OK\\SQLEXPRESS;Initial Catalog = HeladeriaPAV; Integrated Security = True"; //NICO
        //string cadenaConexion = "Data Source=DESKTOP-49CNN6T\\SQLEXPRESS;Initial Catalog=HeladeriaPAV;Integrated Security=True"; //MARCOS
        //string cadenaConexion = "Data Source=DESKTOP-5U8R5O6\\SQLEXPRESS; Initial Catalog=HeladeriaPAV;Integrated Security=True"; //GASTÓN
        //string cadenaConexion = "Data Source=DESKTOP-UOQ5CGK;Initial Catalog=HeladeriaPAV;Integrated Security=True"; // Bruno

        public void IniciarTransaccion()
        {
            controlConexion = TipoConexion.transaccional;
            controlTransaccion = EstadoTransaccion.correcta;
        }


        public EstadoTransaccion CerrarTransaccion()
        {
            if (controlConexion == TipoConexion.transaccional)
            {
                if (controlTransaccion == EstadoTransaccion.correcta)
                {
                    // terminar por commit
                    transaccion.Commit();
                }
                else
                {
                    // terminar por rollback
                    transaccion.Rollback();
                }
                controlConexion = TipoConexion.simple;
                Desconectar();
            }
            return controlTransaccion;
        }


        private void Conectar()  // metodo para conectar
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;

                if (controlConexion == TipoConexion.transaccional)
                {
                    transaccion = conexion.BeginTransaction(IsolationLevel.ReadCommitted);
                    comando.Transaction = transaccion;
                }
            }

        }


        private void Desconectar()  // metodo para desconectar
        {
            if (controlConexion == TipoConexion.simple)
            {
                conexion.Close();
            }

        }


        public DataTable Consulta (string sql)  // devuelve tabla
        {
            Conectar();
            comando.CommandText = sql;   // comando a ejecutar
            DataTable tabla = new DataTable();

            try
            {
                tabla.Load(comando.ExecuteReader()); // carga la tabla y ejecuta la consulta en el motor
            }
            catch (SqlException e)
            {
                controlTransaccion = EstadoTransaccion.error;
                MessageBox.Show("Error con la Base de Datos" + "\n"
                                                             + "En el comando:" + "\n"
                                                             + sql + "\n"
                                                             + "El mensaje es:" + "\n"
                                                             + e.Message);
            }

            Desconectar();
            return tabla;
        }

        private string EjecutarNoSelect(string sql)
        {
            Conectar();
            comando.CommandText = sql;
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                controlTransaccion = EstadoTransaccion.error;
                MessageBox.Show("Error con la Base de Datos" + "\n"
                                                             + "En el comando:" + "\n"
                                                             + sql + "\n"
                                                             + "El mensaje es:" + "\n"
                                                             + e.Message);
            }

            if (sql.ToUpper().IndexOf("INSERT") >= 0)
            {
                DataTable tabla = new DataTable();
                comando.CommandText = "SELECT @@Identity";
                try
                {
                    tabla.Load(comando.ExecuteReader());
                }
                catch (SqlException e)
                {
                    controlTransaccion = EstadoTransaccion.error;
                    MessageBox.Show("Error con la Base de Datos" + "\n"
                                                                 + "En el comando:" + "\n"
                                                                 + sql + "\n"
                                                                 + "El mensaje es:" + "\n"
                                                                 + e.Message);
                }
                Desconectar();
                return tabla.Rows[0][0].ToString();
            }
            else
            {
                Desconectar();
                return "";
            }
        }


        public string Insertar(string sql)
        {
            return EjecutarNoSelect(sql);
        }

        public void Eliminar(string sql)
        {
            EjecutarNoSelect(sql);
        }

        public void Actualizar(string sql)
        {
            EjecutarNoSelect(sql);
        }


        public string Fecha()
        {
            string sql = "select convert (char(10), getdate(),103)";
            DataTable tabla = new DataTable();
            tabla = Consulta(sql);
            return tabla.Rows[0][0].ToString();
        }


        public void InsertarAutomatizado(string NombreTabla, Control.ControlCollection controles)
        {
            string sqlInsertar = "INSERT INTO " + NombreTabla.Trim() + " (";
            string sqlDatos = " VALUES (";
            DataTable Estructura = new DataTable();
            Estructura = EstructuraTabla(NombreTabla);
            for (int i = 0; i < Estructura.Columns.Count; i++)
            {
                string ValorCampo = BuscarValorCampo(Estructura.Columns[i].Caption, NombreTabla, controles);
                if (ValorCampo != "")
                {
                    sqlInsertar += ", " + Estructura.Columns[i].Caption;
                    sqlDatos += ", " + FormatearDato(ValorCampo, Estructura.Columns[i].DataType.Name);
                }
            }
            sqlInsertar = sqlInsertar + ")" + sqlDatos + ")";
            sqlInsertar = sqlInsertar.Replace("(,", "(");
            Insertar(sqlInsertar);
        }

        public void ModificarAutomatizado(string NombreTabla, string restriccion, Control.ControlCollection controles)
        {
            string sqlModificar = "UPDATE " + NombreTabla.Trim() + " SET ";

            DataTable Estructura = new DataTable();
            Estructura = EstructuraTabla(NombreTabla);
            for (int i = 0; i < Estructura.Columns.Count; i++)
            {
                string ValorCampo = BuscarValorCampo(Estructura.Columns[i].Caption, NombreTabla, controles);
                if (ValorCampo != "")
                {
                    sqlModificar += ", " + Estructura.Columns[i].Caption + " = "
                                    + FormatearDato(ValorCampo, Estructura.Columns[i].DataType.Name);
                }
            }
            sqlModificar = sqlModificar + " WHERE" + restriccion;
            sqlModificar = sqlModificar.Replace("SET ,", "SET ");
            Actualizar(sqlModificar);
        }


        public string FormatearDato(string dato,string formato)
        {
            switch (formato)
            {
                case "String":
                    return "'" + dato + "'";
                case "Date":
                case "DateTime":
                    return "convert(date,'" + dato + "', 103)";
                default:
                    return dato;
            }
        }


        private DataTable EstructuraTabla (string NombreTabla)
        {
            string sql = "SELECT TOP 1 * FROM " + NombreTabla.Trim();
            DataTable tabla = new DataTable();
            tabla = this.Consulta(sql);
            return tabla;
        }

        private string BuscarValorCampo(string campo, string NombreTabla, Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name == "TextBox01")
                {
                    if (((TextBox01)item).PpNombreCampo is null)
                        continue;

                    if (((TextBox01)item).PpNombreTabla.IndexOf(NombreTabla) != -1
                        && ((TextBox01)item).PpNombreCampo == campo)
                        return ((TextBox01)item).Text;
                }

                if(item.GetType().Name == "ComboBox01")
                {
                    if (((ComboBox01)item).PpNombreCampo is null)
                        continue;

                    if (((ComboBox01)item).PpNombreTabla.IndexOf(NombreTabla) != -1
                        && ((ComboBox01)item).PpNombreCampo == campo)
                        return ((ComboBox01)item).SelectedValue.ToString();
                }

                if (item.GetType().Name == "TextBox02")
                {
                    if (((TextBox02)item).PpNombreCampo is null)
                        continue;

                    if (((TextBox02)item).PpNombreTabla.IndexOf(NombreTabla) != -1
                        && ((TextBox02)item).PpNombreCampo == campo)
                        return ((TextBox02)item).Text;
                }

            }
            return "";
        }

        public int nextAutoincrement(string tablaBuscada)
        {
            string sql = "SELECT IDENT_CURRENT('"+tablaBuscada+"')+1 AS proximoNumero";
            DataTable tabla = new DataTable();
            tabla = this.Consulta(sql);
            string numero = tabla.Rows[0]["proximoNumero"].ToString();
            return Int32.Parse(numero);
        }
    }
}
