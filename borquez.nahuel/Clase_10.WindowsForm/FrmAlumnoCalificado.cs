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


        public FrmAlumnoCalificado()
        {
            InitializeComponent();

            base.txtNombre.ReadOnly = true;//base.txtNombre.enabled,
            base.txtApellido.ReadOnly = true;
            base.txtLegajo.ReadOnly = true;
            //base.cmbTipoExamen

        }

        public FrmAlumnoCalificado(Alumno alumnoUno) : this()
        {
            this.txtNombre.Text = alumnoUno.Nombre;
            this.txtApellido.Text = alumnoUno.Apellido;
            this.txtLegajo.Text = alumnoUno.Legajo.ToString();
            this.cmbTipoExamen.Text = alumnoUno.Examen.ToString();

        }

    }
}
