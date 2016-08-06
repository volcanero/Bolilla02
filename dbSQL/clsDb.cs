using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace dbSQL
{
    public static  class clsDb
    {
        public static string Actualizar(string Procedimiento, SqlParameter[] param)
        {
            string res = string.Empty;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Procedimiento;
            cmd.Connection = Conexion.cnn;

            if (param != null)
                cmd.Parameters.AddRange(param);

            try
            {
                Conexion.Modo(TipoConexion.Abrir);
                cmd.ExecuteNonQuery();
                Conexion.Modo(TipoConexion.Cerrar);
            }
            catch (SqlException ex)
            {
                res = ex.Message;
                Conexion.Modo(TipoConexion.Cerrar);
            }

            return res;
        }

        public static DataTable Consultar(string Procedimiento, SqlParameter[] param)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Procedimiento;

            try
            {
                Conexion.Modo(TipoConexion.Abrir);
                cmd.Connection = Conexion.cnn;

                if (param != null)
                    cmd.Parameters.AddRange(param);

                da.SelectCommand = cmd;
                da.Fill(dt);

                Conexion.Modo(TipoConexion.Cerrar);
            }
            catch
            {
                dt = null;
            }

            return dt;

        }

        public static DataTable Consultar(string Procedimiento)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Procedimiento;

            try
            {
                Conexion.Modo(TipoConexion.Abrir);
                cmd.Connection = Conexion.cnn;


                da.SelectCommand = cmd;
                da.Fill(dt);

                Conexion.Modo(TipoConexion.Cerrar);
            }
            catch
            {
                dt = null;
            }

            return dt;

        }

        public static DataTable Consultar(string Procedimiento, string Dato)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Procedimiento;
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("Buscar", Dato);

            try
            {
                Conexion.Modo(TipoConexion.Abrir);
                cmd.Connection = Conexion.cnn;

                if (param != null)
                    cmd.Parameters.AddRange(param);

                da.SelectCommand = cmd;
                da.Fill(dt);

                Conexion.Modo(TipoConexion.Cerrar);
            }
            catch
            {
                dt = null;
            }

            return dt;

        }

    }
}
