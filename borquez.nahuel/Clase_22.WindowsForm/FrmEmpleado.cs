using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_22.Entidades;

namespace Clase_22.WindowsForm
{
    public partial class FrmEmpleado : Form
    {
        protected Empleado e1;// = new Empleado();

        public FrmEmpleado()
        {
            InitializeComponent();
            
            this.cmbManejador.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach(TipoManejador tipo in Enum.GetValues(typeof(TipoManejador) ) )
            {
                this.cmbManejador.Items.Add(tipo);
            }
            //this.cmbManejador.SelectedItem = TipoManejador.LimiteSueldo;
        }

        private void cmbManejador_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch(this.cmbManejador.SelectedItem)
            {
                case TipoManejador.LimiteSueldo:

                    e1.limiteSueldo += new LimiteSueldoDelegado(manejadorEventoSueldo);
                    break;
            }


        }


        public static void manejadorEventoSueldo(double sueldo, Empleado emp)
        {
            MessageBox.Show("Sueldo mayor a 18k y menor a 30k:\n"+ emp.ToString() +" \nSueldo ingresado:" +sueldo);
        }
        
        public static void manejadorEventoSueldoMejorado(Empleado emp, EmpleadoEventArgs e)
        {
            MessageBox.Show("Sueldo mayor a 30k: \n"+emp.ToString() + "Sueldo a asignar:" + e.SueldoAsignar);
          
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            e1 = new Empleado(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtLegajo.Text) );

            try
            {
                e1.Sueldo = double.Parse(this.txtSueldo.Text);

            }
            catch(Exception a)
            {
                MessageBox.Show(a.ToString());
            }


        }
    }
}
