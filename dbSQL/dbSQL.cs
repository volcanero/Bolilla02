using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace dbSQL
{
    public enum TipoConexion{ Abrir, Cerrar}

    public static class Conexion
    {
        public static string Servidor;
        public static string Usuario;
        public static string Clave;
        public static string BaseDatos;
        public static SqlConnection cnn = new SqlConnection();

        public static string Modo(TipoConexion Tipo)
        {
            string res = string.Empty;

            string StrCnn = @"Data Source=" + Servidor + ";Initial Catalog=" + BaseDatos + "; User ID = " + Usuario + "; Password= " + Clave;

            try
            {
                if (cnn.State == System.Data.ConnectionState.Closed)
                    cnn.ConnectionString = StrCnn;


                if  ((cnn.State == System.Data.ConnectionState.Closed) && (Tipo == TipoConexion.Abrir))
                    cnn.Open();
                else
                    cnn.Close();
            }

            catch (SqlException ex)
            {
                res = ex.Message;
            }

            return res;
        }
    }
}
