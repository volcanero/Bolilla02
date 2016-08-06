namespace Ejemplo01
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbServidor = new System.Windows.Forms.TextBox();
            this.tbBaseDatos = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVendedor = new System.Windows.Forms.TextBox();
            this.tbComision = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.dgvVendedor = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Base de Datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Clave";
            // 
            // tbServidor
            // 
            this.tbServidor.Location = new System.Drawing.Point(125, 49);
            this.tbServidor.Name = "tbServidor";
            this.tbServidor.Size = new System.Drawing.Size(135, 20);
            this.tbServidor.TabIndex = 4;
            this.tbServidor.Text = "PC-MARCELO\\SVRSQL";
            // 
            // tbBaseDatos
            // 
            this.tbBaseDatos.Location = new System.Drawing.Point(125, 92);
            this.tbBaseDatos.Name = "tbBaseDatos";
            this.tbBaseDatos.Size = new System.Drawing.Size(135, 20);
            this.tbBaseDatos.TabIndex = 5;
            this.tbBaseDatos.Text = "dbLabIII";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(125, 132);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(135, 20);
            this.tbUsuario.TabIndex = 6;
            this.tbUsuario.Text = "marcelo";
            // 
            // tbClave
            // 
            this.tbClave.Location = new System.Drawing.Point(125, 171);
            this.tbClave.Name = "tbClave";
            this.tbClave.Size = new System.Drawing.Size(135, 20);
            this.tbClave.TabIndex = 7;
            this.tbClave.Text = "123";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(33, 222);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 8;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(149, 222);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vendedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Comisión";
            // 
            // tbVendedor
            // 
            this.tbVendedor.Location = new System.Drawing.Point(418, 63);
            this.tbVendedor.Name = "tbVendedor";
            this.tbVendedor.Size = new System.Drawing.Size(249, 20);
            this.tbVendedor.TabIndex = 12;
            // 
            // tbComision
            // 
            this.tbComision.Location = new System.Drawing.Point(422, 108);
            this.tbComision.Name = "tbComision";
            this.tbComision.Size = new System.Drawing.Size(100, 20);
            this.tbComision.TabIndex = 13;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(340, 159);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 14;
            this.btnGrabar.Text = "Agregar ";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // dgvVendedor
            // 
            this.dgvVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedor.Location = new System.Drawing.Point(761, 63);
            this.dgvVendedor.Name = "dgvVendedor";
            this.dgvVendedor.Size = new System.Drawing.Size(384, 150);
            this.dgvVendedor.TabIndex = 15;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(761, 34);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 16;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 432);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dgvVendedor);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.tbComision);
            this.Controls.Add(this.tbVendedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.tbClave);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.tbBaseDatos);
            this.Controls.Add(this.tbServidor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbServidor;
        private System.Windows.Forms.TextBox tbBaseDatos;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbVendedor;
        private System.Windows.Forms.TextBox tbComision;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.DataGridView dgvVendedor;
        private System.Windows.Forms.Button btnMostrar;
    }
}

