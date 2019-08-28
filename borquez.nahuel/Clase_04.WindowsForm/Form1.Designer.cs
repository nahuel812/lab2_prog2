namespace Clase_04.WindowsForm
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
            this.lblEntero = new System.Windows.Forms.Label();
            this.lblCadena = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.txtEntero = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEntero
            // 
            this.lblEntero.AutoSize = true;
            this.lblEntero.Location = new System.Drawing.Point(39, 27);
            this.lblEntero.Name = "lblEntero";
            this.lblEntero.Size = new System.Drawing.Size(38, 13);
            this.lblEntero.TabIndex = 0;
            this.lblEntero.Text = "Entero";
            // 
            // lblCadena
            // 
            this.lblCadena.AutoSize = true;
            this.lblCadena.Location = new System.Drawing.Point(39, 62);
            this.lblCadena.Name = "lblCadena";
            this.lblCadena.Size = new System.Drawing.Size(44, 13);
            this.lblCadena.TabIndex = 1;
            this.lblCadena.Text = "Cadena";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(39, 96);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(109, 96);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(159, 20);
            this.txtFecha.TabIndex = 3;
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(109, 62);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(159, 20);
            this.txtCadena.TabIndex = 4;
            // 
            // txtEntero
            // 
            this.txtEntero.Location = new System.Drawing.Point(109, 27);
            this.txtEntero.Name = "txtEntero";
            this.txtEntero.Size = new System.Drawing.Size(159, 20);
            this.txtEntero.TabIndex = 5;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(42, 238);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(42, 122);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(226, 108);
            this.lstLista.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Rojo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Negro";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(285, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Azul";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 282);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtEntero);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCadena);
            this.Controls.Add(this.lblEntero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntero;
        private System.Windows.Forms.Label lblCadena;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.TextBox txtEntero;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

