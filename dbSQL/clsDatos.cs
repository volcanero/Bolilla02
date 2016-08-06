using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data;
using System.Data.SqlClient;


namespace dbSQL
{
    public static class clsDatos
    {

        public static string Actualizar(object obj, string Procedimiento)
        {
            string res = string.Empty;

            SqlParameter[] param;

            Type Tipo = obj.GetType();

            PropertyInfo[] propiedades = Tipo.GetProperties();

            int Long = propiedades.Length;
            int Index = 0;

            param = new SqlParameter[Long];

           foreach (var prop in propiedades)
            {
                // An array of type ParameterInfo containing the parameters for the indexes. If the property is not indexed, the array has 0 (zero) elements.
                 if (prop.GetIndexParameters().Length == 0)    // 
                {
                    param[Index] = new SqlParameter(prop.Name, prop.GetValue(obj));
                    Index++;
               }
            }

            res = clsDb.Actualizar(Procedimiento, param);

            return res;

        }

        public static List<object> Consultar(object obj, string Procedimiento, SqlParameter[] param)
        {
            List<object> objs = new List<object>();
            DataTable dt =  clsDb.Consultar(Procedimiento, param);

            Type Tipo = obj.GetType();

            PropertyInfo[] propiedades = Tipo.GetProperties();
            int Long = propiedades.Length;
            int Index = 0;
            int Field = 0;

            foreach (DataRow row in dt.Rows)
            {
                object[,] objDato = new object[1,Long];

                Field = 0;

                foreach (var prop in propiedades)
                {
                     objDato[Index,Field] =  row[prop.Name].ToString();
                    Field++;
                   
                }
       
                objs.Add(objDato);

             }
            
            return objs;
         }

        public static List<object> Consultar(object obj, string Procedimiento)
        {
            List<object> objs = new List<object>();
            DataTable dt = clsDb.Consultar(Procedimiento);

            Type Tipo = obj.GetType();

            PropertyInfo[] propiedades = Tipo.GetProperties();
            int Long = propiedades.Length;
            int Index = 0;
            int Field = 0;

            foreach (DataRow row in dt.Rows)
            {
                object[,] objDato = new object[1, Long];

                Field = 0;

                foreach (var prop in propiedades)
                {
                    objDato[Index, Field] = row[prop.Name].ToString();
                    Field++;

                }

                objs.Add(objDato);

            }

            return objs;
        }

        public static List<object> Consultar(object obj, string Procedimiento, string Dato)
        {
            List<object> objs = new List<object>();
            DataTable dt = clsDb.Consultar(Procedimiento, Dato);

            Type Tipo = obj.GetType();

            PropertyInfo[] propiedades = Tipo.GetProperties();
            int Long = propiedades.Length;
            int Index = 0;
            int Field = 0;

            foreach (DataRow row in dt.Rows)
            {
                object[,] objDato = new object[1, Long];

                Field = 0;

                foreach (var prop in propiedades)
                {
                    objDato[Index, Field] = row[prop.Name].ToString();
                    Field++;

                }

                objs.Add(objDato);

            }

            return objs;
        }

    }
}