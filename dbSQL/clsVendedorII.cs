using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbSQL
{
    public class clsVendedorII
    {
        string vendedor;
        decimal comision;

        #region ----------------------- Propiedades -----------------------------------------

        public string Vendedor
        {
            get
            {
                return vendedor;
            }

            set
            {
                vendedor = value;
            }
        }


        public decimal Comision
        {
            get
            {
                return comision;
            }

            set
            {
                comision = value;
            }
        }

        #endregion


        public List<clsVendedorII> Consultar()
        {
            List<clsVendedorII> ListaVendedores = new List<clsVendedorII>();
            List<object> ListaObjetos = new List<object>();

            ListaObjetos = clsDatos.Consultar(this, "spVendedorMostrar");
  
            foreach (object obj in ListaObjetos)
                ListaVendedores.Add(objToVendedor(obj));

              return ListaVendedores;
        }

        public List<clsVendedorII> Consultar(string Buscar)
        {
            List<clsVendedorII> ListaVendedores = new List<clsVendedorII>();
            List<object> ListaObjetos = new List<object>();
      
            ListaObjetos = clsDatos.Consultar(this, "spVendedorMostrar", Buscar);

            foreach (object obj in ListaObjetos)
                ListaVendedores.Add(objToVendedor(obj));

            return ListaVendedores;
        }

        private clsVendedorII objToVendedor(Object obj)
        {
            clsVendedorII oVen = new clsVendedorII();

            oVen.Vendedor = ((object[,])obj)[0, 0].ToString();
            oVen.Comision = decimal.Parse(((object[,])obj)[0, 1].ToString());

            return oVen;
        }

    }
}
