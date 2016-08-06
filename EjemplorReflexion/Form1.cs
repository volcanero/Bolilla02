using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dbSQL;
using System.Reflection;

namespace EjemplorReflexion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        clsVendedorII oVendedor = new clsVendedorII();
        clsArticulos oArticulos = new clsArticulos();
        clsClientes oClientes = new clsClientes();

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion.Usuario = "marcelo";
            Conexion.Clave = "123";
            Conexion.BaseDatos = "dbLabIII";
            Conexion.Servidor = "PC-MARCELO\\SVRSQL";



        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            oVendedor.Vendedor = tbNombre.Text;
            oVendedor.Comision = decimal.Parse(tbComision.Text);

            LeerPropiedades(oVendedor);

        }


        private  void LeerPropiedades(Object obj)
        {
            Type Tipo = obj.GetType();

            lblTipo.Text = Tipo.Name;

            PropertyInfo[] propiedades = Tipo.GetProperties();

            lblLong.Text = propiedades.Length.ToString();
           

            foreach (var prop in propiedades)
            {
                if (prop.GetIndexParameters().Length == 0)
                {
                    lbPropiedades.Items.Add(prop.Name);
                    lbTipo.Items.Add(prop.PropertyType.Name);
                    lbValor.Items.Add(prop.GetValue(obj));

                }
            }

        }


        /*
              PropertyInfo[] props = t.GetProperties();
              Console.WriteLine("Properties (N = {0}):",
                                props.Length);
              foreach (var prop in props)
                  if (prop.GetIndexParameters().Length == 0)
                      Console.WriteLine("   {0} ({1}): {2}", prop.Name,
                                        prop.PropertyType.Name,
                                        prop.GetValue(obj));
                  else
                      Console.WriteLine("   {0} ({1}): <Indexed>", prop.Name,
                                        prop.PropertyType.Name);
  */


        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string res = clsDatos.Actualizar(oVendedor, "spVendedorInsert");

            if (res == string.Empty)
                MessageBox.Show("Grabo Correctamente", "Grabado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(res, "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oArticulos.Articulo = tbArticulo.Text;
            oArticulos.Costo = decimal.Parse(tbCosto.Text);
            oArticulos.CoefUtilidad = decimal.Parse(tbCoefUtilidad.Text);

            LeerPropiedades(oArticulos);
        }

        private void btnGrabarArticulo_Click(object sender, EventArgs e)
        {
            string res = clsDatos.Actualizar(oArticulos, "spArticulosInsert");

            if (res == string.Empty)
                MessageBox.Show("Grabo Correctamente", "Grabado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(res, "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lblEnsamblado_Click(object sender, EventArgs e)
        {
            System.Reflection.Assembly info = typeof(System.Int32).Assembly;

            lblEnsamblado.Text = info.ToString();

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int ind = cboTipoDatos.SelectedIndex;

            switch(ind)
            {
                case 0:
                    dgvDatos.DataSource = oVendedor.Consultar();
                    break;
                case 1:
                    dgvDatos.DataSource = oArticulos.Consultar();
                    break;

                case 2:
                    dgvDatos.DataSource = oClientes.Consultar();
                    break;

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            oClientes.Cliente = tbCliente.Text;
            oClientes.Domicilio = tbDomicilio.Text;
            oClientes.Telefono = tbTelefono.Text;
            oClientes.IdVendedor = int.Parse(tbIdVendedor.Text);

            LeerPropiedades(oClientes);
        }

        private void btnGrabarClientes_Click(object sender, EventArgs e)
        {
            string res = clsDatos.Actualizar(oClientes, "spClientesInsert");

            if (res == string.Empty)
                MessageBox.Show("Grabo Correctamente", "Grabado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(res, "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int ind = cboTipoDatos.SelectedIndex;

            switch (ind)
            {
                case 0:
                    dgvDatos.DataSource = oVendedor.Consultar();
                    break;
                case 1:
                    dgvDatos.DataSource = oArticulos.Consultar();
                    break;

                case 2:
                    dgvDatos.DataSource = oClientes.Consultar(tbBuscar.Text);
                    break;

            }
        }
    }
}
