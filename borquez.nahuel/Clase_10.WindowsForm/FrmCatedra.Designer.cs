namespace Clase_10.WindowsForm
{
    partial class FrmCatedra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpAlumnos = new System.Windows.Forms.GroupBox();
            this.lstAlumnos = new System.Windows.Forms.ListBox();
            this.cmbOrdenamiento = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstAlumnosCalificados = new System.Windows.Forms.ListBox();
            this.grpAlumnosCalificados = new System.Windows.Forms.GroupBox();
            this.grpAlumnos.SuspendLayout();
            this.grpAlumnosCalificados.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAlumnos
            // 
            this.grpAlumnos.Controls.Add(this.lstAlumnos);
            this.grpAlumnos.Controls.Add(this.cmbOrdenamiento);
            this.grpAlumnos.Controls.Add(this.btnModificar);
            this.grpAlumnos.Controls.Add(this.btnCalificar);
            this.grpAlumnos.Controls.Add(this.btnAgregar);
            this.grpAlumnos.Location = new System.Drawing.Point(12, 12);
            this.grpAlumnos.Name = "grpAlumnos";
            this.grpAlumnos.Size = new System.Drawing.Size(670, 238);
            this.grpAlumnos.TabIndex = 0;
            this.grpAlumnos.TabStop = false;
            this.grpAlumnos.Text = "Alumnos";
            // 
            // lstAlumnos
            // 
            this.lstAlumnos.FormattingEnabled = true;
            this.lstAlumnos.Location = new System.Drawing.Point(6, 71);
            this.lstAlumnos.Name = "lstAlumnos";
            this.lstAlumnos.Size = new System.Drawing.Size(537, 121);
            this.lstAlumnos.TabIndex = 3;
            // 
            // cmbOrdenamiento
            // 
            this.cmbOrdenamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdenamiento.FormattingEnabled = true;
            this.cmbOrdenamiento.Location = new System.Drawing.Point(6, 198);
            this.cmbOrdenamiento.Name = "cmbOrdenamiento";
            this.cmbOrdenamiento.Size = new System.Drawing.Size(537, 21);
            this.cmbOrdenamiento.TabIndex = 2;
            this.cmbOrdenamiento.SelectedIndexChanged += new System.EventHandler(this.cmbOrdenamiento_SelectedIndexChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(330, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(132, 46);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(173, 19);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(127, 46);
            this.btnCalificar.TabIndex = 1;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(22, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 46);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstAlumnosCalificados
            // 
            this.lstAlumnosCalificados.FormattingEnabled = true;
            this.lstAlumnosCalificados.Location = new System.Drawing.Point(6, 19);
            this.lstAlumnosCalificados.Name = "lstAlumnosCalificados";
            this.lstAlumnosCalificados.Size = new System.Drawing.Size(553, 134);
            this.lstAlumnosCalificados.TabIndex = 1;
            // 
            // grpAlumnosCalificados
            // 
            this.grpAlumnosCalificados.Controls.Add(this.lstAlumnosCalificados);
            this.grpAlumnosCalificados.Location = new System.Drawing.Point(12, 344);
            this.grpAlumnosCalificados.Name = "grpAlumnosCalificados";
            this.grpAlumnosCalificados.Size = new System.Drawing.Size(670, 165);
            this.grpAlumnosCalificados.TabIndex = 2;
            this.grpAlumnosCalificados.TabStop = false;
            this.grpAlumnosCalificados.Text = "Alumnos Calificados";
            // 
            // FrmCatedra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 521);
            this.Controls.Add(this.grpAlumnosCalificados);
            this.Controls.Add(this.grpAlumnos);
            this.Name = "FrmCatedra";
            this.Text = "FrmCatedra";
            this.grpAlumnos.ResumeLayout(false);
            this.grpAlumnosCalificados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAlumnos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbOrdenamiento;
        private System.Windows.Forms.ListBox lstAlumnos;
        private System.Windows.Forms.ListBox lstAlumnosCalificados;
        private System.Windows.Forms.GroupBox grpAlumnosCalificados;
    }
}