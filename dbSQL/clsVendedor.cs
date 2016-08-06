using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace dbSQL
{
    public class clsVendedor
    {


        public string Agregar(string Vendedor, decimal Comision)
        {
            string res = string.Empty;

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Vendedor", SqlDbType.VarChar);
            param[1] = new SqlParameter("@Comision", SqlDbType.Decimal);

            param[0].SqlValue = Vendedor;
            param[1].SqlValue = Comision;

            res = clsDb.Actualizar("spVendedorInsert", param);

            return res;
        }

        public DataTable Consulta()
        {
            return clsDb.Consultar("spVendedorMostrar");
        }


        public DataTable Consulta(string Buscar)
        {
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Buscar", SqlDbType.VarChar);
            

            param[0].SqlValue = Buscar;

            return clsDb.Consultar("spVendedorMostrar", param);

        }

        public string Modificar(int IdVendedor, string Vendedor, decimal Comision)
        {
            string res = string.Empty;

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@IdVendedor", SqlDbType.Int);
            param[1] = new SqlParameter("@Vendedor", SqlDbType.VarChar);
            param[2] = new SqlParameter("@Comision", SqlDbType.Decimal);

            param[0].SqlValue = IdVendedor;
            param[1].SqlValue = Vendedor;
            param[2].SqlValue = Comision;

            res = clsDb.Actualizar("spVendedorInsert", param);

            return res;

        }


        public string Anular(string IdVendedor)
        {
            string res = string.Empty;

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@IdVendedor", SqlDbType.Int);


            param[0].SqlValue = IdVendedor;


            res = clsDb.Actualizar("spVendedorAnular", param);

            return res;

        }


    }
}
