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

namespace Ejemplo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        clsVendedor oVendedor = new clsVendedor();


        private void btnAbrir_Click(object sender, EventArgs e)
        {
            string res = string.Empty;
            Conexion.Usuario = tbUsuario.Text;
            Conexion.Clave = tbClave.Text;
            Conexion.BaseDatos = tbBaseDatos.Text;
            Conexion.Servidor = tbServidor.Text;

            res = Conexion.Modo(TipoConexion.Abrir);

            if (res == string.Empty)
                MessageBox.Show("Base de Datos Abierta Correctamente", "Abierta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No pudo abrir la Base de Datos: " + res, "Cerrada", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            string res = string.Empty;
            Conexion.Usuario = tbUsuario.Text;
            Conexion.Clave = tbClave.Text;
            Conexion.BaseDatos = tbBaseDatos.Text;
            Conexion.Servidor = tbServidor.Text;

            res = Conexion.Modo(TipoConexion.Abrir);

            if (res == string.Empty)
                MessageBox.Show("Base de Datos Cerrada Correctamente", "Cerrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No pudo cerrar la Base de Datos: " +  res, "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            Conexion.Usuario = tbUsuario.Text;
            Conexion.Clave = tbClave.Text;
            Conexion.BaseDatos = tbBaseDatos.Text;
            Conexion.Servidor = tbServidor.Text;


            string res = oVendedor.Agregar(tbVendedor.Text, decimal.Parse(tbComision.Text));


            if (res == string.Empty)
                MessageBox.Show("Grabo Correctamente", "Grabado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(res, "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Conexion.Usuario = tbUsuario.Text;
            Conexion.Clave = tbClave.Text;
            Conexion.BaseDatos = tbBaseDatos.Text;
            Conexion.Servidor = tbServidor.Text;

            dgvVendedor.DataSource = oVendedor.Consulta();
        }
    }
}
