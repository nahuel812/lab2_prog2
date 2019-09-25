using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_10.Entidades;

namespace Clase_10.WindowsForm
{
    public partial class FrmAlumnoCalificado : FrmAlumno
    {
        private AlumnoCalificado miAlumnoCalificado;

        public AlumnoCalificado AlumnoCalificado { get { return this.miAlumnoCalificado; } }

        public FrmAlumnoCalificado()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            this.txtLegajo.Enabled = false;
        }

        public FrmAlumnoCalificado(Alumno alumnoUno) : this()
        {
            this.txtNombre.Text = alumnoUno.Nombre;
            this.txtApellido.Text = alumnoUno.Apellido;
            this.txtLegajo.Text = alumnoUno.Legajo.ToString();
            this.cmbTipoExamen.Text = alumnoUno.Examen.ToString();

            this.txtApellido.Enabled = false;
            this.txtNombre.Enabled = false;
            this.cmbTipoExamen.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            miAlumnoCalificado = new AlumnoCalificado(this.txtNombre.Text, this.txtApellido.Text, Convert.ToInt32(this.txtLegajo.Text), (ETipoExamen)(this.cmbTipoExamen.SelectedItem), Convert.ToDouble(this.txtNota.Text));
            
            this.DialogResult = DialogResult.OK;

        }
    }
}
