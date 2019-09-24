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
    public partial class FrmCatedra : Form
    {
        private Catedra _catedraLista = new Catedra();
        private List<AlumnoCalificado> _listaAlumnosCalificados = new List<AlumnoCalificado>();

        public FrmCatedra()
        {
            InitializeComponent();
            foreach (ETipoOrdenamiento a in Enum.GetValues(typeof(ETipoOrdenamiento)))
            {
                this.cmbOrdenamiento.Items.Add(a);
            }
            this.cmbOrdenamiento.SelectedItem = ETipoOrdenamiento.LegajoAscendente;
            this.cmbOrdenamiento.DropDownStyle = ComboBoxStyle.DropDownList;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAlumno frmAlumno = new FrmAlumno();
            frmAlumno.ShowDialog();//abro el frmAlumno, cuando se cierre la ventana sigue el programa

            if(frmAlumno.DialogResult == DialogResult.OK)//pregunto si se presiono ok en el frmAlumno, si se presiono 
            {
                if (_catedraLista + frmAlumno.Alumno)//a catedra le agrego el alumno del frmAlumno que cargue
                {
                    ActualizarListadoAlumno();//actualizo la lista
                }
                else
                {
                    MessageBox.Show("No se puede cargar al alumno, ya se encuentra el legajo en sistema");
                }
            }
        }

        private void ActualizarListadoAlumno()
        {
            lstAlumnos.Items.Clear();
            
            switch(cmbOrdenamiento.SelectedItem.ToString())
            {
                case "LegajoAscendente":
                    _catedraLista.Alumnos.Sort(Alumno.OrdenarPorLegajoAsc);
                    break;
                case "LegajoDescendente":
                    _catedraLista.Alumnos.Sort(Alumno.OrdenarPorLegajoDesc);
                    break;
                case "ApellidoAscendente":
                    _catedraLista.Alumnos.Sort(Alumno.OrdenarPorApellidoAsc);
                    break;
                case "ApellidoDescendente":
                    _catedraLista.Alumnos.Sort(Alumno.OrdenarPorApellidoDesc);
                    break;
                //default:
            }
            
            for (int i = 0; i < _catedraLista.Alumnos.Count(); i++)
            {
                lstAlumnos.Items.Add(Alumno.Mostrar(_catedraLista.Alumnos[i]));
                //lstAlumnos.Items.Add(_catedraLista.ToString());//muestra la lista de alumno
            }
        }
        private void cmbOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActualizarListadoAlumno();//uso el metodo que actualiza la lista cada vez que se elije otro ordenamiento
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            int indice;
            indice = this.lstAlumnos.SelectedIndex;

            FrmAlumnoCalificado frmAlumnoCalificado = new FrmAlumnoCalificado(_catedraLista.Alumnos[indice]);
            frmAlumnoCalificado.ShowDialog();
            


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice;
            indice = this.lstAlumnos.SelectedIndex;
            

            FrmAlumno frmAlumno = new FrmAlumno(_catedraLista.Alumnos[indice]);//tomo un alumno de catedra en el indice seleccionado
            frmAlumno.ShowDialog();
            
            //if()

        }
    }
}
