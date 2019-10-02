using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace CentralitaWindowsForms
{
    public partial class FrmProvincia : Llamada
    {
        private Provincial nuevaLlamadaProvincia;
        public Provincial Provincia { get { return this.nuevaLlamadaProvincia; } }
        public FrmProvincia()
        {
            InitializeComponent();
            foreach(Franja aux in Enum.GetValues(typeof(Franja)))
            {
                cmbFranja.Items.Add(aux);
            }
            this.cmbFranja.SelectedItem = Franja.Franja_1;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            nuevaLlamadaProvincia = new Provincial(this.textBox1.Text, (Franja)this.cmbFranja.SelectedIndex, (float)Convert.ToDouble(this.txtDuracion.Text), this.textBox2.Text);
            DialogResult = DialogResult.OK;
        }
    }
}
