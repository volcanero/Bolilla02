using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbSQL
{
    public class clsArticulos
    {
        string articulo;
        decimal costo;
        decimal coefUtilidad;

#region   ------------------------------- Propiedades-------------------------------------------------------------------------------------------------------------
        public string Articulo
        {
            get
            {
                return articulo;
            }

            set
            {
                articulo = value;
            }
        }

        public decimal Costo
        {
            get
            {
                return costo;
            }

            set
            {
                costo = value;
            }
        }

        public decimal CoefUtilidad
        {
            get
            {
                return coefUtilidad;
            }

            set
            {
                coefUtilidad = value;
            }
        }

        #endregion




        public List<clsArticulos> Consultar()
        {

            List<clsArticulos> ListaArticulos = new List<clsArticulos>();
            List<object> ListaObjetos = new List<object>();

            ListaObjetos = clsDatos.Consultar(this, "spArticulosMostrar");


            foreach (object obj in ListaObjetos)
            {

                ListaArticulos.Add(objToArticulos(obj));

            }


            return ListaArticulos;
        }


        private clsArticulos objToArticulos(Object obj)
        {
            clsArticulos oArt = new clsArticulos();


            oArt.articulo = ((object[,])obj)[0, 0].ToString();
            oArt.costo = decimal.Parse(((object[,])obj)[0, 1].ToString());
            oArt.coefUtilidad = decimal.Parse(((object[,])obj)[0, 2].ToString());



            return oArt;

        }



    }
}
