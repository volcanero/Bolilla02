using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbSQL
{
    public class clsClientes
    {
        string cliente;
        string domicilio;
        string telefono;
        int idVendedor;


        #region -------------------------- Propiedades ----------------------------------------

        public string Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
            }
        }

        public string Domicilio
        {
            get
            {
                return domicilio;
            }

            set
            {
                domicilio = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public int IdVendedor
        {
            get
            {
                return idVendedor;
            }

            set
            {
                idVendedor = value;
            }
        }


        #endregion


        public List<clsClientes> Consultar()
        {
            List<clsClientes> ListaClientes = new List<clsClientes>();
            List<object> ListaObjetos = new List<object>();

            ListaObjetos = clsDatos.Consultar(this, "spClientesMostrar");

            foreach (object obj in ListaObjetos)
                ListaClientes.Add(objToClientes(obj));

            return ListaClientes;
        }

        public List<clsClientes> Consultar(string Buscar)
        {
            List<clsClientes> ListaClientes = new List<clsClientes>();
            List<object> ListaObjetos = new List<object>();

            ListaObjetos = clsDatos.Consultar(this, "spClientesMostrar",Buscar);

            foreach (object obj in ListaObjetos)
                ListaClientes.Add(objToClientes(obj));

            return ListaClientes;
        }


        private clsClientes objToClientes(Object obj)
        {
            clsClientes oCli = new clsClientes();

            oCli.Cliente = ((object[,])obj)[0, 0].ToString();
            oCli.Domicilio =  ((object[,])obj)[0, 1].ToString();
            oCli.Telefono = ((object[,])obj)[0, 2].ToString();
            oCli.IdVendedor = int.Parse(((object[,])obj)[0, 3].ToString());

            return oCli;
        }









    }
}
