using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using dbSQL;

namespace Ejemplo03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion.Servidor = @"PC-MARCELO\SVRSQL";
            Conexion.BaseDatos = "LabIII";
            Conexion.Usuario = "Marcelo";
            Conexion.Clave = "123";



            SqlCommand cmdSel = new SqlCommand();
            cmdSel.Connection = Conexion.cnn;
            cmdSel.CommandType = CommandType.StoredProcedure;
            cmdSel.CommandText = "spVendedorMostrar";






            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmdSel;
    


        }
    }
}
